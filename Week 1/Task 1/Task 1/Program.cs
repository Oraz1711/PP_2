using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //сreate dinamic array 
            int n = int.Parse(Console.ReadLine()); //enter size of array 
            string[] a = Console.ReadLine().Split(); //fill the array

            foreach (string s in a) //appeal to each element of the array 
            {
                int cnt = 0;

                for (int i = 2; i <= a.Length; i++)
                {
                    if (int.Parse(s) % i == 0) //check on the remainder 
                    {

                        cnt  += 1; //counter of primes 
                    }
                }
                if (cnt == 1)
                {
                    list.Add(s); //adding prime numbers 
                }
            }

            Console.WriteLine(list.Count); //output total number of all elements of the array
            foreach (string s in list)
            {
                Console.Write(s + " "); //output all elements itself 
            }
            Console.ReadKey();//if need to close a console (without this command console closed immediately after launching)
        }
    }
}