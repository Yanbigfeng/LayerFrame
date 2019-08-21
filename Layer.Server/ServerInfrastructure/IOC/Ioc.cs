using System;
using System.Reflection;
using Unity;

namespace ServerInfrastructure
{
    /// <summary>
    /// 依赖注入之区域注入方式
    /// 没有写入到配置文件可传参注入
    /// </summary>
    public class Ioc
    {
        private static readonly UnityContainer _container;

        static Ioc()
        {
            _container = new UnityContainer();
        }

        public static void RegisterInheritedTypes(Assembly assembly, Type baseType)
        {
            _container.RegisterInheritedTypes(assembly, baseType);
        }

        public static void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _container.RegisterType<TInterface, TImplementation>();
        }

        public static T Get<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
