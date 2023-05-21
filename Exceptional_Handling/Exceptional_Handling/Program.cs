using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptional_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y, z;
            try
            {
                Console.WriteLine("Enter first number");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                z = Convert.ToInt32(Console.ReadLine());
                if (z != 0)
                {
                    x = y / z;
                    Console.WriteLine("Div=" + x);
                }
                else
                {
                    throw new Exception("Don't put zero in denominator");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            Console.ReadKey();
        }
    }
}
