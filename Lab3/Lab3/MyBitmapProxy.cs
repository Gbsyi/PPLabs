using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3
{
    class MyBitmapProxy : IMyBitmap
    {
        public (int Width, int Height) GetSize(string path)
        {
            (int Width, int Height) result = (0,0);
            if (!Regex.IsMatch(path, @"\w*.bmp")) {
                throw new Exception($"Path \'{path}\' is not bitmap");
            }

            Regex pattern = new Regex(@"\w*_\d*x\d*.bmp");
            if (pattern.IsMatch(path))
            {
                string[] numbers = Regex.Split(path, @"\D+");
                List<int> nums = new List<int>();
                foreach(string num in numbers)
                {
                    if(result.Width == 0)
                    {
                        int.TryParse(num, out result.Width);
                    }
                    else
                    {
                        int.TryParse(num, out result.Height);
                        return result;
                    }
                }
            }
            else
            {
                MyBitmap bmp = new();
                return bmp.GetSize(path);
            }
            return result;
        }
    }
}
