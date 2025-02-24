namespace Delegates1
{
    //step 1 : create a delegate class matching the signature
    //of the func to be called
    public delegate void Del1();
    //Object
    //Delegate
    //MulticastDelegate
    //Del1
    public delegate int DelAdd(int a, int b);
    internal class Program
    {
        static void Main1()
        {
            //step 2 : create a delegate reference and create an object.
            //Pass the function name as a parameter
            Del1 objDel = new Del1(Display);

            //step 3 : call the func via the delegate reference
            objDel();
        }
        static void Main2()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel = Show;
            objDel();
        }
        static void Main3()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Show;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

        }
        static void Main5()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();


            Console.WriteLine();
            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main6()
        {
            Del1 objDel = Class1.Display;
            objDel();

            Class1 oClass = new Class1();
            objDel = oClass.Show;
            objDel();

        }
        static void Main7()
        {
            DelAdd oAdd = Add;
            Console.WriteLine(oAdd(10, 20));

            Console.WriteLine();
            oAdd += Subtract;
            Console.WriteLine(oAdd(10, 20));
            //-----
            //int ans;
            //ans = Add(10, 20);
            //ans = Subtract(10, 20);
            //Console.WriteLine(ans);

        }
    }

    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("Display");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }

    }
}

//func name passed as a parameter
namespace Delegates2
{
    public delegate int DelAdd(int a, int b);
    internal class Program
    {
       
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main()
        {
            Console.WriteLine(CallMathOperation(Add,1,2));
            Console.WriteLine(CallMathOperation(Subtract,10,5));
        }

        static int CallMathOperation(DelAdd objDelAdd, int i, int j) //objDelAdd= Add
        {
            return objDelAdd(i, j);
        }


        
    }

   
}