using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//call a func async using delegate.BeginInvoke
namespace AsyncCodeWithDelegates1
{
    internal class Program
    {
        static void Main1()
        {
            Console.WriteLine("before");
            Action oDel = Display;
            oDel.BeginInvoke(null,null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display()
        {
            Thread.Sleep(3000);
            Console.WriteLine("display called");
        }
    }
}

//Display has parameters
namespace AsyncCodeWithDelegates2
{
    internal class Program
    {
        static void Main2()
        {
            Console.WriteLine("before");
            Action<string> oDel = Display;
            oDel.BeginInvoke("passed value",null, null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            Thread.Sleep(3000);
            Console.WriteLine("display called" + s);
        }
    }
}

//Display has parameters and a return value
//use a callback function know when display is over
namespace AsyncCodeWithDelegates3
{
    internal class Program
    {
        static void Main3()
        {
            Console.WriteLine("before");
            Func<string,string> oDel = Display;
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

//Display has parameters and a return value
//use a callback function know when display is over
//also get the return value using oDel.EndInvoke
namespace AsyncCodeWithDelegates4
{
    internal class Program
    {
        static void Main4()
        {
            Console.WriteLine("before");
            Func<string, string> oDel = Display;
            IAsyncResult ar1= oDel.BeginInvoke("passed value", delegate(IAsyncResult ar)
            {
                Console.WriteLine("callback func called");
                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);
            }, null);
            
            Console.WriteLine("after");
            Console.ReadLine();
        }
      
        static string Display(string s)
        {
            Thread.Sleep(3000);
            Console.WriteLine("display called" + s);
            return s.ToUpper();
        }
    }
}

//Display has parameters and a return value
//use a callback function know when display is over
//pass oDel as the last paramter to BeginInvoke,
//oDel recd in callback func as ar.AsyncState
namespace AsyncCodeWithDelegates5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("before");
            Func<string, string> oDel = Display;
            //oDel.BeginInvoke("passed value", MyCallbackFunc, "extra data passed to callback");
            oDel.BeginInvoke("passed value", MyCallbackFunc, oDel);

            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void MyCallbackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback func called");

            //string last_param = ar.AsyncState.ToString();
            //Console.WriteLine(last_param);
            Func<string, string> oDel = (Func<string, string>)ar.AsyncState;
            string retval = oDel.EndInvoke(ar);
            Console.WriteLine(retval);
        }
        static string Display(string s)
        {
            Thread.Sleep(3000);
            Console.WriteLine("display called" + s);
            return s.ToUpper();
        }
    }
}


//Display has parameters and a return value
//NO CALLBACK, uses Polling - horrible
namespace AsyncCodeWithDelegates6
{
    internal class Program
    {
        static void Main3()
        {
            Console.WriteLine("before");
            Func<string, string> oDel = Display;
            IAsyncResult ar = oDel.BeginInvoke("passed value", null, null);
            Console.WriteLine("after");

            while (!ar.IsCompleted) ;
            string retval = oDel.EndInvoke(ar);
            Console.WriteLine(retval);

            Console.ReadLine();
        }
        
        static string Display(string s)
        {
            Thread.Sleep(3000);
            Console.WriteLine("display called" + s);
            return s.ToUpper();
        }
    }
}