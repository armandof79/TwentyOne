using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_P160
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an optional second integer");
            int b = Convert.ToInt32(Console.ReadLine());
            var obj = new Class160();
            Console.WriteLine(obj.Method1(a, b));
          
            Console.ReadLine();

        }
    }
}
