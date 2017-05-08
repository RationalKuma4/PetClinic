using System;
using Microsoft.AspNet.Identity;
using Microsoft.Practices.Unity;
using PetClinic.WebService.Controllers;
using PetClinic.WebService.DataServices;
using PetClinic.WebService.DataServices.Interfaces;
using PetClinic.WebService.Models;
using PetClinic.WebService.Repositories.Interfaces.Veterinarian;
using PetClinic.WebService.Repositories;
using PetClinic.WebService.Repositories.Interfaces.Base;
using Microsoft.Owin.Security;
using PetClinic.WebService.Models.CustomUser;

namespace PetClinic.WebService.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<AccountController>(new InjectionConstructor());

            container.RegisterType<PetClinicDbContext>();
            container.RegisterType<ISecureDataFormat<AuthenticationTicket>>();

            RegisterServices(container);
            RegisterRepositories(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IVeterinarianService, VeterinarianService>();
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<IVeterinarianReader, RepositoryVeterinarian>();
            container.RegisterType<IVeterinarianWriter, RepositoryVeterinarian>();
            container.RegisterType<IDisposeDataBase, RepositoryVeterinarian>();
        }
    }
}
