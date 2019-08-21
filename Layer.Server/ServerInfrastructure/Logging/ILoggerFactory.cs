using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInfrastructure.Logging
{
    /// <summary>
    /// 日志输出工厂：原本想可以使用这个进行切换不同的日志方式例如lognet4或自定义的
    /// </summary>
   public interface  ILoggerFactory
    {
        ILogHelp CreateLogger();
    }
}
