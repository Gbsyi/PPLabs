using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogger
{
    public class Logger
    {
        private static Logger _instance;
        private string _fileName;
        private Logger() { }
        public static Logger GetLogger()
        {
            if (_instance == null) { 
                _instance = new Logger();
}            return _instance;
        }
        public static void SetLogFile(string fileName)
        {
            _instance._fileName = fileName;
        }
        public void LogInline(params object[] text)
        {
            using(StreamWriter sw = new StreamWriter(_fileName,true,Encoding.Default))
            {
                foreach(object elem in text)
                {
                    sw.Write(elem.ToString() + " ");
                }
            }
        }
        public void Log(params object[] text)
        {
            using (StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
            {
                foreach (object elem in text)
                {
                    sw.Write(elem.ToString() + " ");
                }
                sw.Write("\n");
            }
        }
    }
}
