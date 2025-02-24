namespace ExtensionMethods
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;

            i = i.Add(5);
            i.Display();

            string s = "aaa";
            s.Show();
        }
        static void Main2()
        {
            int i = 100;
            i = MyExtClass.Add(i, 5);
            MyExtClass.Display(i);
            i.ExtMethodForBaseClass();

            string s = "aaa";
            MyExtClass.Show(s);
            s.ExtMethodForBaseClass();
        }
        static void Main()
        {
            ClsMaths objClsMaths = new ClsMaths();
            Console.WriteLine(objClsMaths.Add(10, 5));
            Console.WriteLine(objClsMaths.Multiply(10, 5));
            Console.WriteLine(objClsMaths.Subtract(10, 5));

        }
    }

    public static class MyExtClass
    {
        public static int Add(this int i, int j)
        {
            return i + j;
        }
        //step 1 : create a static method in a static class
        //step 2: the 1st parameter should the type for which
        //you are writing an extension  method,
        //preceded by the 'this' keyword
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void Show(this string s)
        {
            Console.WriteLine(s);
        }
        //if you add an ext method for the base class,
        //it is also available for the derived class
        public static void ExtMethodForBaseClass(this object o)
        {
            Console.WriteLine(o);
        }

        //if you add an ext method for the interface,
        //it is also available for all the classes that
        // implement the interface
        public static int Subtract(this IMathOperations oIMath,int i, int j)
        {
            return i - j;
        }
    }

    public interface IMathOperations
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }
    public class ClsMaths : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
