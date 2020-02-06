using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_p192
{
    public enum DaysOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter current day of the week");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                DaysOfTheWeek today = (DaysOfTheWeek)
                Console.WriteLine("you entered: " + today);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
