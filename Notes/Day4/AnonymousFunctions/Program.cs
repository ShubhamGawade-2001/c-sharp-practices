namespace AnonymousFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Action o1 = delegate()
            {
                Console.WriteLine(++i);
                Console.WriteLine("anon method");
            };
            o1();
            Console.WriteLine(i);

            Func<int, int, int> o2 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(o2(10,5));

        }

       
    }
}
