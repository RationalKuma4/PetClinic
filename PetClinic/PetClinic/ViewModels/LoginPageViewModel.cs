using System.Windows.Input;
using PetClinic.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace PetClinic.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand NavCommand
        {
            get
            {
                return new Command(() =>
                {
                    _navigationService.NavigateAsync(PageNames.ResgisterUserPageName);
                });
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
