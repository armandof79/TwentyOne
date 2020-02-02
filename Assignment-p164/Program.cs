using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p164
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to devide by 2");
            int a = Convert.ToInt32(Console.ReadLine());
            Class164.Method164(a);
            Console.ReadLine();
        }
    }
}
