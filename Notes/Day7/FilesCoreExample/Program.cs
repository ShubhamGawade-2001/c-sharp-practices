namespace FilesCoreExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteTextFile();
            ReadTextFile();
        }

        private static void WriteTextFile()
        {

            StreamWriter writer = File.CreateText("C:\\aaaa\\a.txt");
            writer.WriteLine("Hello World");
            writer.WriteLine("Line 2");
            writer.WriteLine("Almost Done for the day");
            writer.Close();
        }
        private static void ReadTextFile()
        {
            string s;
            StreamReader reader = File.OpenText("C:\\aaaa\\a.txt");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }
    }
}
