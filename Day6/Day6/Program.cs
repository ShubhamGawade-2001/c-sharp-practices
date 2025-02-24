using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main()
        {
            Class1 cObj = new Class1();
            cObj.InvalidI += CObj_InvalidI1;
            cObj.InvalidI += CObj_InvalidIHandler2;
            cObj.I = 1000;
             Console.WriteLine(cObj.I);
        }

        private static void CObj_InvalidIHandler2(int InvalidValue)
        {
            throw new NotImplementedException();
        }

        private static void CObj_InvalidI1(int i)
        {
            Console.WriteLine("event fired "+i);
        }

    }

    public delegate void InvalidIDel(int InvalidValue);
    public class Class1
    {
        public event InvalidIDel InvalidI;
        private int i;
        public int I
        { 
            get { return i; }
            set {
                if (value < 100)
                    i = value;
                else 
                    InvalidI(value);
                
            }
        }
    }
}
