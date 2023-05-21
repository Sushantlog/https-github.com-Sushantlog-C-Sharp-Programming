using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Marks : ");
            int Marks = Convert.ToInt32(Console.ReadLine());

            if(Marks >=90 ) {
                Console.WriteLine("You Got A Grade.");
            }
            else if(Marks >= 75)
            {
                Console.WriteLine("You Got B Grade. ");
            }
            else if (Marks >= 60)
            {
                Console.WriteLine("You Got C Grade. ");
            }
            else
            {
                Console.WriteLine("You Got D Grade. ");
            }
            Console.ReadLine();
        }
    }
}
