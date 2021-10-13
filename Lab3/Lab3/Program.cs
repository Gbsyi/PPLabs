using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] testPaths = new string[4] 
            { 
                "file.bmp", 
                "file_100x200.bmp", 
                "file.txt", 
                "no_file.bmp"
            };
            MyBitmapProxy bmp = new();
            (int Width, int Height) pictureSize;
            foreach (string path in testPaths)
            {
                try {
                    pictureSize = bmp.GetSize(path);
                    Console.WriteLine($"Picture size = {pictureSize.Width} x {pictureSize.Height}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Path \'{path}\' not found");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
