using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p176
{
    public class Employee : Person, Assignment_p179.IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit!")
        }
    }
}
