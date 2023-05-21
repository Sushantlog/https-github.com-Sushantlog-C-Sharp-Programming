using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = " main thread";
            Console.WriteLine(mainThread.Name);
            countdown();
            countup();

            Console.WriteLine(mainThread.Name + " is completed");
            Console.ReadKey();

        }
        public static void countdown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #1 is complete..!");
        }

        public static void countup()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("timer #2 is complete..!");
        }

    }
}
