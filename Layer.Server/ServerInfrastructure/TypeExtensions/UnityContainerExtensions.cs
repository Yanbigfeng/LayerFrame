using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity;

namespace ServerInfrastructure
{
    public static class UnityContainerExtensions
    {
        /// <summary>
        /// Unity扩展注册方法
        /// </summary>
        /// <param name="container"></param>
        /// <param name="assembly"></param>
        /// <param name="baseType"></param>
        public static void RegisterInheritedTypes(this IUnityContainer container, Assembly assembly, Type baseType)
        {
            var allTypes = assembly.GetTypes();
            var baseInterfaces = baseType.GetInterfaces();
            foreach (var type in allTypes)
            {
                if (type.BaseType != null && type.BaseType.GenericEq(baseType))
                {
                    var typeInterface = type.GetInterfaces().FirstOrDefault(x => !baseInterfaces.Any(bi => bi.GenericEq(x)));
                    if (typeInterface == null)
                    {
                        continue;
                    }
                    container.RegisterType(typeInterface, type);
                }
            }
        }
    }
}
