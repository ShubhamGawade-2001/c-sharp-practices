using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class p1 { }
//    static class s11{ }

//    internal class Program
//    {



//        //static void Main(string[] args)
//        //{
//        //    System.Console.WriteLine("Hello World");
//        //    Console.WriteLine("next line");
//        //}
//        static int i = 1;
//        int y = 2;
//        static void show(int y)
//        {
//            Console.WriteLine(i);
//            Console.WriteLine(y);

//        }
//        static void Main()
//        {

//            Program obj= new Program();
//            Console.WriteLine(obj.y);
//            Program.show(obj.y);
//        }
//    }
//}
//namespace n1
//{
//    public class Class1 { }
//    public class Class2 { }
//    namespace n1a
//    { 
//        public class Class3 { }

//    }
//}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Try programiz.pro");

        //int i, j;
        //int[,] arr = new int[3, 3];
        //for (i = 0; i < 3; ++i)
        //{
        //    for (j = 0; j < 3; ++j)
        //    {
        //        arr[i, j] = i * 2 + i * 2;
        //        Console.WriteLine(arr[i, j]);
        //    }
        //    Console.ReadLine();
        //}
        int[] numer = { 4, 8, 16, 32, 64, 128 };
        int[] denom = { 2, 0, 4, 4, 0, 8 };
        for (int i = 0; i < numer.Length; i++)
        {
            try
            {
                int[] div = new int[7];
                div[i] = numer[i] / denom[i];
            }
            catch (DivideByZeroException)
            {


                Console.WriteLine("Can not Divide by zero");
            }
        }
    }
}