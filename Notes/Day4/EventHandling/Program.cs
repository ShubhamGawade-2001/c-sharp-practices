namespace EventHandling1
{
    internal class Program
    {
        //static void Main()
        //{
        //    Class1 objClass1 = new Class1();
        //    objClass1.InvalidP1 += objClass1_InvalidP1;
        //    objClass1.P1 = 1000;
        //}

        //static void objClass1_InvalidP1()
        //{
        //    Console.WriteLine("Event handled");
        //}
        static void Main1()
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.InvalidP1 += Handler2;
            objClass1.P1 = 1000;
        }

        private static void ObjClass1_InvalidP1()
        {
            Console.WriteLine("Event handled");
        }
        private static void Handler2()
        {
            Console.WriteLine("Event handled - handler 2");
        }
    }

    //step 1 : create a delegate class having the same signature
    // as the event handler function
    public delegate void InvalidP1EventHandler();
    public class Class1
    {
        //step 2 : declare the event
        //event is a delegate reference
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event 
                    if(InvalidP1 != null)
                        InvalidP1();
                }
            }
        }
    }
}

namespace EventHandling2
{
    internal class Program
    {
        
        static void Main()
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.P1 = int.Parse(Console.ReadLine());
        }

        private static void ObjClass1_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("invalid value -" + InvalidValue);
        }
    }

    //step 1 : create a delegate class having the same signature
    // as the event handler function
    public delegate void InvalidP1EventHandler(int InvalidValue);
    public class Class1
    {
        //step 2 : declare the event
        //event is a delegate reference
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event 
                    if (InvalidP1 != null)
                        InvalidP1(value);
                }
            }
        }
    }
}