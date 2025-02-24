using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day8
{
    namespace AsyncCodeWithDelegates3
    {
        internal class Program
        {
            static void Main1()
            {
                Console.WriteLine("before");
                Func<string, string> oDel = Display;
                //oDel.BeginInvoke("passed value", new AsyncCallback(MyCallbackFunc), null);
                oDel.BeginInvoke("passed value", MyCallbackFunc, null);
                Console.WriteLine("after");
                Console.ReadLine();
            }
            static void MyCallbackFunc(IAsyncResult ar)
            {
                Console.WriteLine("callback func called");
            }
            static string Display(string s)
            {
                Thread.Sleep(3000);
                Console.WriteLine("display called" + s);
                return s.ToUpper();
            }
        }
    }
}
