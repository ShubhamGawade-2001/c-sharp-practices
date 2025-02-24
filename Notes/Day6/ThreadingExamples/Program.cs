using System.Collections.Generic;

namespace ThreadingExamples1
{
    internal class Program
    {
        static void Main0()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            t1.Start();
            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main1()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            t1.IsBackground = true;
            t2.IsBackground = true;

            t1.Start();
            t2.Start();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main2()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            t1.Start();
            t2.Start();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main : " + i);
            }
            t1.Join(); //waiting call
            Console.WriteLine("code to called after func1 is over");
        }
        static void Main3()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }

        static void Main4()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            if(t1.ThreadState == ThreadState.Unstarted)
                t1.Start();

            //t1.Abort();
            //t1.Suspend();
            //t1.Resume();

            //if(t1.ThreadState== ThreadState.)            


            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
                Thread.Sleep(5000);

            }
        }
        static void Main5()
        {
            AutoResetEvent wh = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("f1:" + i);
                    if (i % 50 == 0)
                    {
                        //instead of Suspend, use this
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }
            });
            t1.Start();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 1....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 2....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 3....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 4....");
            wh.Set();
        }

        static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i);
                Thread.Sleep(5000);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second : " + i);
                Thread.Sleep(5000);

            }
        }
    }
}

namespace ThreadingExamples2
{
    internal class Program
    {
        static void Main2()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            //t1.Start(10); //pass one value - int

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);

            t1.Start(list);
            t2.Start("bbb");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        //to pass multiple parameters
        //1. ValueTuple
        //2. pass an array/collection - if similar data types for parameters
        //3. create a class or struct - pass obj of class/struct
        //4. write an local function/anon method /lambda- no need to pass any parameters, anon method can access
        //local variables in the calling code.

        static void Func1(object obj)
        {
            List<int> list =(List <int>) obj;

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i + obj.ToString());
            }

        }
        static void Func2(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second : " + i + obj.ToString());
            }

        }

    }
}


//ThreadPool
namespace ThreadingExamples3
{
    class MainClass
    {
        static void PoolFunc1(object o)
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("First Thread " + i.ToString() + o.ToString());
            }
        }
        static void PoolFunc2(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread " + i.ToString());
            }
        }
        static void Main()
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1));
            //ThreadPool.QueueUserWorkItem(PoolFunc1);

           // ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1),"data");
            //ThreadPool.QueueUserWorkItem(PoolFunc2,"parameter passed");


            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1));
            //ThreadPool.QueueUserWorkItem(PoolFunc1);


            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1), "aaa");
            //ThreadPool.QueueUserWorkItem(PoolFunc1, "aaa");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc2));

            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("Main Thread " + i.ToString());
            //}
            int workerthreads, iothreads;

            //ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);
            //ThreadPool.SetMinThreads()
            //ThreadPool.SetMaxThreads
            //ThreadPool.GetMinThreads(out workerthreads, out iothreads);
            ThreadPool.GetMaxThreads(out workerthreads, out iothreads);
            Console.WriteLine(workerthreads);
            Console.WriteLine(iothreads);

            Console.ReadLine();
        }
    }
}
