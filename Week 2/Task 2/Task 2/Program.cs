using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static bool Check(int x)
        {
            int cnt = 0;
            if (x == 1) return true;
            if (x == 2) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    cnt++;
            }
            if (cnt > 0)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("text.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string n = sr.ReadLine();
            string[] number = n.Split();

            foreach (string s in number)
            {
                if (Check(int.Parse(s)) == false)
                {
                    sw.Write(s + " ");
                }
            }
            sr.Close();
            sw.Close();
        }

    }
}