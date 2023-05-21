using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_dimension
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] ar =new int[5];
            for(int i=0; i <= 4; i++)
            {
                Console.WriteLine("Enter Element At Position "+(i+1));
                ar[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------------------------------------");
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Value At Arr["+i+"] = " + ar[i]);
            }
            Console.ReadLine();

        }

    }
}

