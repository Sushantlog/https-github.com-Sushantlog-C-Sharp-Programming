using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class customer
    {
        static int customerid;
        static string customername;
        static string customerorder;
        static int orderprice;

        public static void customerdetails()
        {
            Console.WriteLine("Enter Product Id : ");
            customerid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name : ");
            customername = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Customer Order : ");
            customerorder = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Order Price : ");
            orderprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");

        }

        public static void orderdescount()
        {
            int descount;
            Console.WriteLine("Hello" + " " + customername + " " + "Your Order Name Is :" + customerorder, "\n");

            Console.WriteLine(customername + "Your Order Price Is :" + orderprice, "\n");

            descount = orderprice / 10;
            Console.WriteLine("Your Order Descount Is :" + descount, "\n");
            int finalprice;

            finalprice = orderprice - descount;

            Console.WriteLine("Your Final Price Is :" + finalprice, "\n");

            Console.WriteLine("Thank You For Visit Our Store..");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            customer.customerdetails();
            customer.orderdescount();
            Console.ReadLine();

        }
    }
}
