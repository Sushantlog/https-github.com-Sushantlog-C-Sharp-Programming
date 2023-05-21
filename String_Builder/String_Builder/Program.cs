using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("hello");
            Console.WriteLine(sb);
            Console.WriteLine("--------------Append Method---------------");
            Console.WriteLine(sb.Append("world"));
            Console.WriteLine("--------------Remove Method-------------------");
            sb.Remove(2, 3);
            Console.WriteLine(sb);
            Console.WriteLine("--------------Insert Method-------------------");
            Console.WriteLine(sb.Insert(2, "XYZ"));
            Console.WriteLine("--------------Replace Method-------------------");
            Console.WriteLine(sb.Replace("hello", "hi"));
            Console.WriteLine("--------------Equals Method--------------------");
            StringBuilder sb2 = new StringBuilder("hello");
            Console.WriteLine(sb.Equals(sb2));
            Console.WriteLine("--------------Clear Method------------------");
            Console.WriteLine(sb.Clear());
            Console.ReadLine();
        }
    }
}
