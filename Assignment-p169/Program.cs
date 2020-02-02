using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p169
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Employee() { FirstName = "Sample", LastName = "Student" };
            obj.SayName();
            Console.ReadLine();

        }
    }
}
