using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using PetClinic.Models;
using Newtonsoft.Json;

namespace PetClinic.DataServices
{
    public class RestDataServices : IRestDataServices
    {
        private readonly HttpClient _client;
        private AuthenticationHeaderValue _authenticationHeader;

        public RestDataServices()
        {
            _client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
        }

        public async Task LoginAsync(OwnerUser owner)
        {
            var uri = new Uri(GlobalSettings.RestUrl);

            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<OwnerUser>(content);
            }
        }
    }
}
