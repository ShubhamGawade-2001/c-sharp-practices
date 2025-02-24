using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main()
        {
            int i = 10;
            i.Display();

            i = 100;
            Console.WriteLine(i.Add(50));
        }
    }
    public static class MyClass
    {
        public static void Display(this int i) {
            Console.WriteLine(i);
        }
        public static int Add(this int i, int j) {
            return i + j;
        }
    }
}
