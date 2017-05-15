using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using PetClinic.WebService.Results;

namespace PetClinic.WebService.Filters
{
    public abstract class BasicAuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        public virtual bool AllowMultiple => false;

        public string Realm { get; set; }

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            HttpRequestMessage request = context.Request;
            AuthenticationHeaderValue authorization = request.Headers.Authorization;

            if (authorization == null) return;

            if (!authorization.Scheme.Equals("Basic")) return;

            if (string.IsNullOrEmpty(authorization.Parameter))
            {
                context.ErrorResult = new AuthenticationFailureResult("Faltan credenciales", request);
                return;
            }

            Tuple<string, string> userAndPassword = ExtractUserNameAndPassword(authorization.Parameter);

            if (userAndPassword == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Credenciales invalidas", request);
                return;
            }

            string userName = userAndPassword.Item1;
            string password = userAndPassword.Item2;

            IPrincipal principal = await AuthenticateAsync(userName, password, cancellationToken);

            if (principal == null)
                context.ErrorResult = new AuthenticationFailureResult("Usuario o contraseña invalidos", request);
            else
                context.Principal = principal;
        }

        protected abstract Task<IPrincipal> AuthenticateAsync(string userName, string password,
            CancellationToken cancellationToken);

        private Tuple<string, string> ExtractUserNameAndPassword(string authorizationParameter)
        {
            byte[] credentialBytes;

            try
            {
                credentialBytes = Convert.FromBase64String(authorizationParameter);
            }
            catch (FormatException)
            {
                return null;
            }

            Encoding encoding = Encoding.ASCII;
            encoding = encoding.Clone() as Encoding;
            encoding.DecoderFallback = DecoderFallback.ExceptionFallback;
            string decoderCredentials;

            try
            {
                decoderCredentials = encoding.GetString(credentialBytes);
            }
            catch (DecoderFallbackException)
            {
                return null;
            }

            if (string.IsNullOrEmpty(decoderCredentials)) return null;

            int colonIndex = decoderCredentials.IndexOf(':');

            if (colonIndex == -1) return null;

            string userName = decoderCredentials.Substring(0, colonIndex);
            string password = decoderCredentials.Substring(colonIndex + 1);
            return new Tuple<string, string>(userName, password);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            Challenge(context);
            return Task.FromResult(0);
        }

        private void Challenge(HttpAuthenticationChallengeContext context)
        {
            string parameter;
            if (string.IsNullOrEmpty(Realm))
                parameter = null;
            else
                parameter = "realm=\"" + Realm + "\"";
            context.ChallengeWith("Basic", parameter);
        }
    }
}