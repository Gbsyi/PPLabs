using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LoggerSingleton
{
    public interface ILogger
    {
        public void SetLogFileName(string fileName);
        public void Log(object message);
        public void Log(params object[] message);
        public void LogInline(object message);
        public void LogInline(params object[] message);

    }
}
