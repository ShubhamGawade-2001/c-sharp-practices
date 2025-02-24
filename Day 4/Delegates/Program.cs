using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Del();
    internal class Program
    {
        static void Main1()
        {
            Program pObj= new Program();
            Del delObj = new Del(new Program().SayHello);
            delObj();
            // string s = "sdas";
            //delObj = Show;
            delObj =(Del) Delegate.Combine(new Del(Show));
            delObj();

        }
        public void SayHello()
        {
            Console.WriteLine("Hii");
        }
        public static void Show()
        {
            Console.WriteLine("  show");
        }
        //public static void Show(String s)
        //{
        //    Console.WriteLine("  "+s);
        //}
    }
}

namespace Delegates
{
    public delegate int delAdd(int a, int b);
     internal class Demo
    {
        static void Main()
        {
            //Pro pObj= new Pro();
            //Console.WriteLine(pObj.MathOp(10,20));
             MathOp(Add,10,20);
        }
            static int Add(int a, int b)
        {
            return a + b;
        }
        static int MathOp(delAdd objDelAdd,int a,int b)
        {
            return objDelAdd(a, b);
        }
    }

}
