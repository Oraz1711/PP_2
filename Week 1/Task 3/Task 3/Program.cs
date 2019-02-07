using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//enter the total number of elements
            int[] a = new int[n];//create an array
            string[] s = Console.ReadLine().Split();//create an string array
            for (int i = 0; i < a.Length; i++)//using cycle convert all elemets from foramt string to int 
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < a.Length; i++)//using cycle again to double elemets 
            {
                Console.Write("{0} {0} ", a[i]);//"{0} {0} " - command for dobble 
            }
            Console.ReadKey();//if need to close a console (without this command console closed immediately after launching) 
        }
    }
}