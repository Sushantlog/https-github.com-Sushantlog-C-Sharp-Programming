using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class complex
    {
        private int x;
        private int y;

        public complex()
        {

        }
        public complex(int i, int j)
        {
            x = i;
            y = j;
        }

        public void showxy()
        {
            Console.WriteLine("{0}{1}", x, y);
        }
        public static complex operator -(complex c)
        {
            complex temp = new complex();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex(10, 20);
            c1.showxy();
            complex c2 = new complex();
            c2.showxy();
            c2 = -c1;
            c2.showxy();
            Console.ReadLine();
        }
    }
}
