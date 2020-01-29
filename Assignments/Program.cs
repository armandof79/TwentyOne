using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload1 obj = new Overload1();
            Console.WriteLine(obj.Function1(4));
            Overload1 obj2 = new Overload1();
            Console.WriteLine(obj2.Function1(7.5f));
            Overload1 obj3 = new Overload1();
            Console.WriteLine(obj3.Function1("5"));
            Console.ReadLine();
        }
    }
}
