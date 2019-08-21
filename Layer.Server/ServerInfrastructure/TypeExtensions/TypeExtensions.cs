using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInfrastructure
{
    /// <summary>
    /// type类型扩展
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// 类型对比方法
        /// </summary>
        public static bool GenericEq(this Type type, Type toCompare)
        {
            return type.Namespace == toCompare.Namespace && type.Name == toCompare.Name;
        }
    }
}
