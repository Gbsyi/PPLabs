using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public class FileCache : ICacheStrategy
    {
        private string _fileName;
        public FileCache(string fileName) 
        { 
            _fileName = fileName;
        }
        public void Delete(string key)
        {
            List<string> data = new List<string>();
            using (StreamReader sr = new StreamReader(_fileName))
            {
                string[] line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(":");
                    if(line[0] == key)
                    {
                        continue;
                    }
                    else
                    {
                        data.Add($"{ line[0]}:{line[1]}\n");
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(_fileName))
            {
                foreach (string line in data)
                {
                    sw.Write(line);
                }
            }
        }

        public string Read(string key)
        {
            using(StreamReader sr = new StreamReader(_fileName))
            {
                
                string[] lineData;
                while (!sr.EndOfStream)
                {
                    lineData = sr.ReadLine().Split(":");
                    if (lineData[0].Equals(key))
                    {
                        return lineData[1];
                    }
                }

                return null;
            }
        }

        public void Write(string key, string value)
        {
            string readResult = this.Read(key);

            if (readResult == null)
            {
                using (StreamWriter sw = new StreamWriter(_fileName, true, Encoding.Default))
                {
                    sw.Write($"{key}:{value}\n");
                }
            }
            else if (readResult.Equals(value))
            {
                throw new KeyExistException("Такая пара уже существует");
            }
            else
            {
                List<string> data = new List<string>();
                using (StreamReader sr = new StreamReader(_fileName))
                {
                    string[] line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split(":");
                        if (line[0] == "")
                            throw new Exception("Файл повреждён");
                        if (line[0] == key)
                        {
                            data.Add($"{ line[0] }:{ value }\n");
                        }
                        else
                        {
                            data.Add($"{ line[0] }:{ line[1] }\n");
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(_fileName))
                {
                    foreach(string line in data)
                    {
                        sw.Write(line);
                    }
                }
            }
        }
    }
}
