using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    class Input
    {
        protected int Width;
        protected int Height;

        public void SetWidth(int w)
        {
            Width = w;
        }

        public void SetHeight(int h)
        {
            Height = h;
        }
    }

    class Rectangle : Input
    {
        public int GetArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            Console.WriteLine("Enter Width:");
            int width = Convert.ToInt32(Console.ReadLine());
            obj.SetWidth(width);

            Console.WriteLine("Enter Height:");
            int height = Convert.ToInt32(Console.ReadLine());
            obj.SetHeight(height);

            int area = obj.GetArea();
            Console.WriteLine("Area: " + area);
            Console.ReadLine();
        }
    }
}
