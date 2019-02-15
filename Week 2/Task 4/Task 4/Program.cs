using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\so171\Desktop\PP_2\Week 2\Task 4\Task 4\bin\Debug\path\txt.txt"; //путь к первой папке с файлом
            string file1 = @"C:\Users\so171\Desktop\PP_2\Week 2\Task 4\Task 4\bin\Debug\path1\txt.txt";// второй путь , куда мы будем копировать файл 
            if (File.Exists(@"C:\Users\so171\Desktop\PP_2\Week 2\Task 4\Task 4\bin\Debug\path\txt.txt"))// проверка на существования файла
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("You cannot do this operation");
            }
            File.Copy(file, file1);// копирование файла из первой папки во вторую
            Console.WriteLine("Copied");
            if (File.Exists(@"C:\Users\so171\Desktop\PP_2\Week 2\Task 4\Task 4\bin\Debug\path\txt.txt"))//проверка
            {
                File.Delete(@"C:\Users\so171\Desktop\PP_2\Week 2\Task 4\Task 4\bin\Debug\path\txt.txt");//удаление файла с первой папки после копирования во вторую папку
            }
            Console.WriteLine("Original file deleted");
        }
    }
}