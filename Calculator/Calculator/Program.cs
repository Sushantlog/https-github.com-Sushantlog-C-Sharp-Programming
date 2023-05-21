using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Calculator ===================");
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("================================================");

            Console.WriteLine("1.Addition\t\n2.Substraction\t\n3.Multiplication\t\n4.Division");

            Console.WriteLine("================================================");

            Console.WriteLine("Enter Your Choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:Console.WriteLine("Addition Of Two Number Is : " + (num1+num2));
                    break;
                case 2:Console.WriteLine("Substraction Of Two Number is : "+(num1-num2));
                    break;
                case 3:Console.WriteLine("Multiplication Of Two Number is : " + (num1 * num2));
                    break;
                case 4:Console.WriteLine("Division Of Two NUmber is : "+(num1 / num2));
                    break;
                default: Console.WriteLine("Enter valid Entry !");
                    break;
            }
            Console.ReadLine();
        }
    }
}
