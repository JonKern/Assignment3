using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Account Log Activity:");
            Console.WriteLine("-----------------------------");
            var s = new Student("1357911");
            s.Name = "Satoshi Nakamoto";
            s.Major = "Baking Science and Technology";
            s.StartDate = "01/01/2023";
            s.GradDate = "12/10/2022";
            s.StateProvTerr = "Prince Edward Island";
            s.Country = "Canada";
            s.Email = "s.nakamoto@dsu.edu";
            s.Phone = "902-620-3628";
            s.MailAddress = "1 Dewar Ln, O'Leary, PE C0B 1V0, Canada";

            Console.WriteLine("\nPress q to exit program");
            while (Console.ReadKey().Key != ConsoleKey.Q){}
        }
    }
}
