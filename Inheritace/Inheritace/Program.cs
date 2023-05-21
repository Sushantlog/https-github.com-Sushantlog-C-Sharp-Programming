using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace
{
    class Input
    {
        protected int Width;
        protected int Height;

        public void SetWidth(int w)
        {
          int Width = w;
        }
        public void SetHeight(int w)
        {
           int Height = w;
        }
    }

    class Rectangle : Input
    {
        public int GatArea()
        {
            return Width * Height ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            Console.WriteLine("Enter Width :");
            int Width = Convert.ToInt32(Console.ReadLine());
            obj.SetWidth(Width);

            Console.WriteLine("Enter Height :");
            int Height = Convert.ToInt32(Console.ReadLine());
            obj.SetHeight(Height);

            int area = obj.GatArea();
            Console.WriteLine("Area: " + area);
            Console.ReadLine();

        }
    }
}
