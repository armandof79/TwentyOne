using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p197
{
    public struct Number
    {
        public float amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.amount = 100.00f;
            Console.WriteLine(number.amount);
            Console.ReadLine();

        }
    }
}
