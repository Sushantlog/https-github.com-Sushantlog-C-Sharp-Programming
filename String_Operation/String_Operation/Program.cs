using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Easy Software";
            Console.WriteLine(str);
            Console.WriteLine("--------------ToUpper-------------------");
            Console.WriteLine(str.ToUpper());
            Console.WriteLine("______________Tolower_____________________");
            Console.WriteLine(str.ToLower());
            Console.WriteLine("--------------length of string--------------");
            Console.WriteLine(str.Length);
            Console.WriteLine("--------------charAt 2 index---------------");
            Console.WriteLine(str[2]);
            Console.WriteLine("-------------startswith So------------------");
            Console.WriteLine(str.StartsWith("So"));
            Console.WriteLine("--------------Endswith re---------------------");
            Console.WriteLine(str.EndsWith("re"));
            Console.WriteLine("--------------CompareTo----------------------");
            Console.WriteLine(str.CompareTo("Easy Software"));
            Console.WriteLine(str.CompareTo("Easy software"));
            Console.WriteLine("--------------Equals----------------------");
            Console.WriteLine(str.Equals("easy software"));
            Console.WriteLine(str.Equals("Easy Software"));
            Console.WriteLine("--------------replace-----------------------");
            string newstr = str.Replace("Easy", "hard");
            Console.WriteLine(newstr);
            Console.ReadLine();
        }
    }
}
