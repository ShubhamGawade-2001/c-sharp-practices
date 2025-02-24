namespace ActionFuncPredicate
{
    internal class Program
    {
        static void Main1()
        {
            Action o1 = Display;
            o1();
            Action<string> o2 = Display;
            o2("aa");
        }
        static void Main()
        {
            Func<string> o1 = GetTime;
            Console.WriteLine( o1());

            Func<int,int> o2 = MakeDouble;
            Console.WriteLine(  o2(10));

            Func<int,int,int> o3 = Add;
            Console.WriteLine(o3(10,5));

            Func<int, bool> o4 = IsEven;
            Console.WriteLine(o4(10));

            Func<Employee, bool> o5 = IsBasicGreaterThan10000;
            Employee o = new Employee { Basic = 20000 };
            Console.WriteLine(o5(o));

            Predicate<int> o6 = IsEven;
            Console.WriteLine(o6(10));

            Predicate<Employee> o7 = IsBasicGreaterThan10000;
            Console.WriteLine(o7(o));


        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display"+s);
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int MakeDouble(int a)
        {
            return a * 2;
        }
        static bool IsEven(int a)
        {
            if(a%2==0) 
                return true;
            else
                return false;
        }
        static bool IsBasicGreaterThan10000(Employee emp)
        {
            if (emp.Basic >10000)
                return true;
            else
                return false;
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }

    }
}
