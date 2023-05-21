using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18 ) {
                Console.WriteLine("You can Open Your Linkdin Account.");
            }
            else
            {
                Console.WriteLine("You can not Open Your Linkdin Account.");
            }
            Console.ReadLine();
        }
    }
}
