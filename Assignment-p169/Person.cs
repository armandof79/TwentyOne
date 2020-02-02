using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p169
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
            Console.ReadLine();
        }
    }

}
