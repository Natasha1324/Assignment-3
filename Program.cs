using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_No._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            //Convert seconds to minutes
            double minutes = seconds / 60.0;

            //Convert minutes to hours
            double hours = minutes / 60.0;
            
            //Convert hours to days
            double days = hours / 24.0;
            
            //Convert days to months
            double months = days / 30.0;

            Console.WriteLine($" {seconds} seconds equal to: ");
            Console.WriteLine($" {minutes} minutes");
            Console.WriteLine($" {hours} hours");
            Console.WriteLine($" {days} days");
            Console.WriteLine($" {months} months");
        }

    }
}
                           