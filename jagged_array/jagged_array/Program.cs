using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]
{
              new int[] { 11,21,56,78},
              new int[] { 11,21,23,67,89},
              new int[] { 11,21,}
};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
