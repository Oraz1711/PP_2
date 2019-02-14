using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void ReadFiles(DirectoryInfo files, int level)
        {
            foreach (FileInfo f in files.GetFiles())
            {
                Space(level);
                Console.WriteLine(f.Name);
            }

            foreach (DirectoryInfo fi in files.GetDirectories())
            {
                Space(level);
                Console.WriteLine(fi.Name);
                ReadFiles(fi, level + 1);
            }
        }

        public static void Space(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("     ");
        }
        static void Main(string[] args)
        {
            DirectoryInfo files = new DirectoryInfo("/Users/so171/Desktop/PP_2/Week 1");
            ReadFiles(files, 0);

            Console.ReadKey();
        }
    }
}
