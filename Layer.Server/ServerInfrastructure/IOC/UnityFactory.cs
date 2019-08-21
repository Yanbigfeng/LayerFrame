using System;
using System.IO;
using System.Configuration;
using System.Reflection;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using ServerInfrastructure.Help.Config;


namespace ServerInfrastructure
{
    public class UnityFactory
    {
        private static IUnityContainer _iUnityContainer = null;
        private UnityFactory()
        {

        }
        static UnityFactory()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "IOC\\Unity.Config");
            //Configuration configuration = LibConfig.InitConfig("IOC\\Unity");
            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

            _iUnityContainer = new UnityContainer();
            section.Configure(_iUnityContainer, "MyContainer");
        }

        public static IUnityContainer GetContainerInstance()
        {
            return _iUnityContainer;
        }

        public static T GetServer<T>()
        {
            try
            {
                return _iUnityContainer.Resolve<T>();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
