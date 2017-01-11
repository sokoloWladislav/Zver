using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using BuisnessLogicLevel.Interfaces;
using BuisnessLogicLevel.Servicies;

namespace Website.App_Start
{
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            string connectionString = "DefaultConnection";
            container.RegisterType<IUserService, UserService>(new InjectionFactory(c => new UserService(connectionString)));
        }
    }
}
