using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the current date and time to the console.
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now; //Creating a new DateTime object and assigning it the current date and time.
            Console.WriteLine(now); //Printing the current date and time
            Console.ReadLine(); //Sending the output to the console 

            //Asking the user for a number.
            Console.WriteLine("Enter a number: ");
            double X = Convert.ToInt32(Console.ReadLine()); //Capturing the user input

            //Printing to the console the exact time it will be in X hours.

            //Using the built-in method of the DateTime class to add X hours to the current date and time.
            Console.WriteLine("The exact time it will be in " + X + "hours is: " + now.AddHours(X));
            Console.ReadLine(); //Sending the result to the console          
        }
    }
}
