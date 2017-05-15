using Microsoft.Practices.Unity;
using PetClinic.Views;
using PetClinic.Views.Usuarios;
using Prism.Unity;
using Xamarin.Forms;

namespace PetClinic
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(PageNames.LoginPageName);
        }

        protected override void RegisterTypes()
        {
            RegisterPages(Container);
        }

        private void RegisterPages(IUnityContainer container)
        {
            container.RegisterTypeForNavigation<NavigationPage>();
            container.RegisterTypeForNavigation<MainPage>();
            container.RegisterTypeForNavigation<LoginPage>();
            container.RegisterTypeForNavigation<RegisterUserPage>();
        }
    }
}
