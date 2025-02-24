using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            demo d=new demo();
            d.p3 = 10;
            
            Console.WriteLine(d.p3);
        }
    }
    public class demo
    {

        private int p4;
        public int p3 { set; get; }
    }
}
