using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!");

            int a = 10;
            string b = "label";
            System.Console.WriteLine("Variables: {0}, {1}", a, b);

            var c = "label2";
            

            System.Console.WriteLine("\n");
            System.Console.WriteLine("Value: {0}", c);
            System.Console.WriteLine("Type: " + c.GetType());
            System.Console.WriteLine("Length: " + c.Length);
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
