using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface allarea
    {
        void rectangle_area();
        void triangle_area();
        void circle_area();
    }
    class angle : allarea
    {
        public void rectangle_area()
        {
            Console.WriteLine("======= Rectangle Area ========== ");
            Console.WriteLine("Enter the Height : ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Width : ");
            int w = Convert.ToInt32(Console.ReadLine());

            int area;
            area = h * w;
            Console.WriteLine("Rectangle Area = " + area);
        }

        public void triangle_area()
        {
            Console.WriteLine("========Triangel Area========");
            Console.WriteLine("Enter Height : ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Base : ");
            double b = Convert.ToDouble(Console.ReadLine());

            double area = 0.5f * h * b;
            Console.WriteLine("Area of Triangle : " + area);
        }

        public void circle_area()
        {
            Console.WriteLine("============= Area of Circle =============");
            float r = 2.2f;
            float area = 3.14f * r * r;
            Console.WriteLine("Area of Circle : " + area);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            angle angle = new angle();
            angle.rectangle_area();
            angle.triangle_area();
            angle.circle_area();
            Console.ReadLine();
        }
    }
}
