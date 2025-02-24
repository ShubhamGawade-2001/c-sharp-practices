using System;

namespace EventHandling
{
    internal class Program
    {
        static void Main()
        {
            Class1 objC = new Class1();
            objC.InvalidP1 += objC_InvalidP1;
            objC.P1 = 200;
        }
        static void objC_InvalidP1()
        {
            Console.WriteLine("Event handled");
        }
    }

    public delegate void InvalidP1EventHandler();
    public class Class1
    {

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
                    InvalidP1();
                }
            }
        }
    }
}