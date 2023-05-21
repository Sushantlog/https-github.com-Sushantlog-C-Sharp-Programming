using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
