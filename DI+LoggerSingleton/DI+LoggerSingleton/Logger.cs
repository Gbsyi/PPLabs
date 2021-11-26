using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LoggerSingleton
{
    public class Logger : ILogger
    {
        private string _fileName;
        public Logger()
        {
        }
        public void SetLogFileName(string fileName)
        {
            _fileName = fileName;
        }
        public void Log(object message)
        {
            using(StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
            {
                sw.WriteLine(message.ToString());
            }
        }

        public void Log(params object[] message)
        {
            using (StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
            {
                foreach (object o in message)
                {
                    sw.Write(o.ToString());
                }
                sw.Write("\n");
            }
        }

        public void LogInline(object message)
        {
            using (StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
            {
                sw.Write(message);
            }
        }

        public void LogInline(params object[] message)
        {
            using (StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
            {
                foreach (object o in message)
                {
                    sw.Write(o.ToString());
                }
            }
        }
    }
}
