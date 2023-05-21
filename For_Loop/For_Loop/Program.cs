using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nmber of row : ");
            int n =Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for(int Space = 0; Space < n-i-1; Space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();           
            }
            for(int i = 0; i < n;i++)
            {
                for(int space = 0; space < i; space++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j<n-i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
