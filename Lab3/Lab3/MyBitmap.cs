using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class MyBitmap : IMyBitmap
    {
        public (int Width, int Height) GetSize(string path)
        {
            Bitmap bitmap = new Bitmap(path);
            return (bitmap.Width, bitmap.Height);
        }
    }
}
