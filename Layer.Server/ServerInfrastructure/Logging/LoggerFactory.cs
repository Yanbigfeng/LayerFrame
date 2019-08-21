using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInfrastructure.Logging
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogHelp CreateLogger()
        {
            ILogHelp Log = new LogHelp();
            return Log;
        }
    }
}
