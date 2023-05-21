using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Row :");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while(n > i) {
                int space = 0;
                while(space<n-i-1) { 
                    Console.Write(" ");
                    space++;
                }
                int j = 0;
                while(j < i+1) {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
