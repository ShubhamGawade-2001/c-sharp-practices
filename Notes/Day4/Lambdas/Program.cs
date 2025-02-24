using System.ComponentModel.DataAnnotations;

namespace Lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> o1 = MakeDouble;
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate(int a)
            {
                return a * 2;
            };
            Console.WriteLine(o2(10));

            Func<int, int> o3 = (a) => a * 2;
            Console.WriteLine(o3(10));

            Func<int, int> o4 = a => a * 2;
            Console.WriteLine(o4(10));

            Func<int, int, int> o5 = (a, b) => a + b;
            Console.WriteLine(o5(10,5));

            Func<string> o6 = ()=> DateTime.Now.ToLongTimeString();
            Console.WriteLine(o6());

            Func<int, bool> o7 = x => x % 2 == 0;
            Func<int, bool> o8 = x =>
            {
                if (x % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o7(10));
            Console.WriteLine(o8(10));

            Predicate<Employee> o9 = obj => obj.Basic > 10000;
            Employee o = new Employee { Basic = 20000 };
            Console.WriteLine(o9(o));
        }
        static int MakeDouble(int a)
        {
            return a * 2;
        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }

    }
}
