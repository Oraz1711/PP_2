using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sample
{
    class Volume
    {
        public int a;
        public int b;
        public int c;
        public Volume(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void count(int V)
        {
            V = a * b * c;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Volume v = new Volume(1, 2, 3);
            StreamReader sr = new StreamReader("text.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string n = sr.ReadLine();
            string[] number = n.Split();

            foreach (string s in number) 
            {
                while(true)
                {
                    sw.WriteLine(s);
                }
            }
            sr.Close();
            sw.Close();
        }
    }

