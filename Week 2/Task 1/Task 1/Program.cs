using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        public static bool Is_Palindrom(string s)  
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            if (!Is_Palindrom(s))     
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            Console.ReadKey();
        }
    }
}