using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new { a = 10,b="anonnymous example" };
            Console.WriteLine(obj.a);
            Class1 c1obj = new Class1();
            c1obj.i = 1;
            c1obj.j = 2;

            Console.WriteLine(c1obj.Check());
        }
    }

    public partial class Class1
    {
        private bool valid = true;

        partial void Validate();

        public bool Check()
        {
            Console.WriteLine("inside check");
            Validate();
            Console.WriteLine("after validate ");
            return valid;
        }
        public int i;
    }
    public partial class Class1
    {
        partial void Validate()
        {
            Console.WriteLine("INside p2 () ");
            valid = false;
        }
        public int j;
    }
}
