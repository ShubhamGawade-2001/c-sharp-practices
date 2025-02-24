using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbuiltDelegates
{

    internal class Program
    {
        static void Main()
        {
            Action o1 = Display;
            o1();
            Program pO= new Program();
            Action<string> o2 = pO.Display2;
            o2(" string s");

            Func<int, int, int> o3 = Add;
            Console.WriteLine(o3(10,20));    

        }

        static int Add(int a,int b) 
        {
            return a+ b;
        }
        static void Display() 
        {
            Console.WriteLine("hiiiii");
        }
        public void Display2(string s) 
        { 
            Console.WriteLine("    D2"+s);
        }
    }
}
