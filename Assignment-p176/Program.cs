using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p176
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Employee();
            obj.firstName = "Sample";
            obj.lastName = "Student";
            obj.SayName();
            Console.ReadLine();
        }
    }
}
