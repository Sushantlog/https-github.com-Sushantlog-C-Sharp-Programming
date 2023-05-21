using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Matrix size : ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int[,] a = new int[n, m];

            Console.WriteLine("Enter Element One By One : ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("element is given below : ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
