using System.Text;

namespace FileHandling { }
//{
//    internal class Program
//    {
//        static List<Employee> lstEmp = new List<Employee>();
//        public static void AddRecs()
//        {

//            lstEmp.Add(new Employee { ENo = 1, EName = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
//            lstEmp.Add(new Employee { ENo = 2, EName = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
//            lstEmp.Add(new Employee { ENo = 3, EName = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
//            lstEmp.Add(new Employee { ENo = 4, EName = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
//            lstEmp.Add(new Employee { ENo = 5, EName = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
//            lstEmp.Add(new Employee { ENo = 6, EName = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
//            lstEmp.Add(new Employee { ENo = 7, EName = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
//            lstEmp.Add(new Employee { ENo = 8, EName = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
//        }
//        static void Main1()
//        {

//            Console.WriteLine("Hello, World!");
//            Console.ReadLine();
//            Employee emp = new()
//            {

//                ENo = 11,
//                EName = "yash",
//                Basic = 120000,
//                DeptNo = 201,
//                Gender = "M"
//            };
//            //Console.WriteLine("created emp "+emp.EName);
//            //WriteToFile(emp);
//            //Console.ReadLine();
//            //ReadFromFile();
//        }


//        private static void WriteToFile(Employee emp)
//        {
//            StreamWriter writer = File.AppendText("F:\\try\\employees.txt");
//            writer.WriteLine(emp);
//            writer.Close();
//        }

//        private static void ReadFromFile()
//        {
//            string s;
//            StreamReader reader = File.OpenText("F:\\try\\employees.txt");

//            while ((s = reader.ReadLine()) != null)
//            {
//                Console.WriteLine(s);
//            }

//            reader.Close();
//        }

//    }
//    public class Employee
//    {
//        public int ENo { get; set; }

//        public string EName { get; set; }

//        public decimal Basic { get; set; }

//        public int DeptNo { get; set; }

//        public string Gender { get; set; }

//        public override string ToString()
//        {
//            return EName + " , " + ENo.ToString() + " , " + Basic.ToString() + " , " + DeptNo.ToString();
//        }
//    }
//}

namespace FileHandling2
{

//    class class1
//    {
//        static List<Employee1> lstEmp1 = new List<Employee1>();
//        public static void AddRecs1()
//        {

//            lstEmp1.Add(new Employee1 { ENo = 1, EName = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
//            lstEmp1.Add(new Employee1 { ENo = 2, EName = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
//            lstEmp1.Add(new Employee1 { ENo = 3, EName = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
//            lstEmp1.Add(new Employee1 { ENo = 4, EName = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
//            lstEmp1.Add(new Employee1 { ENo = 5, EName = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
//            lstEmp1.Add(new Employee1 { ENo = 6, EName = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
//            lstEmp1.Add(new Employee1 { ENo = 7, EName = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
//            lstEmp1.Add(new Employee1 { ENo = 8, EName = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
//        }
//        static void Main()
//        {
//            AddRecs1();
//            Console.WriteLine("in file");
//           // WriteToFile1(lstEmp1);
//            ReadFromFile1();
//        }
//        private static void WriteToFile1(List<Employee1> emp)
//        {
//            StreamWriter writer = File.AppendText("F:\\try\\employees2.txt");
//            foreach (var e in emp)
//            {
//                writer.WriteLine(e.ToString());
//            }
//            writer.Close();
//        }
//        private static void ReadFromFile1() 
//        {
//            string s;
//            StreamReader reader = File.OpenText("F:\\try\\employees2.txt");
//            Console.WriteLine("File contains :");
//            while ((s = reader.ReadLine()) != null)
//            {
//                Console.WriteLine(s);
//            }
//            reader.Close();
//        }
//    }
//    public class Employee1
//    {
//        public int ENo { get; set; }

//        public string EName { get; set; }

//        public decimal Basic { get; set; }

//        public int DeptNo { get; set; }

//        public string Gender { get; set; }

//        public override string ToString()
//        {
//            return EName + " , " + ENo.ToString() + " , " + Basic.ToString() + " , " + DeptNo.ToString();
//        }
//    }
}

namespace FileHandling3
{

    class class2
    {
        static List<Employee1> lstEmp1 = new List<Employee1>();
        public static void AddRecs1()
        {

            lstEmp1.Add(new Employee1 { ENo = 1, EName = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp1.Add(new Employee1 { ENo = 2, EName = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp1.Add(new Employee1 { ENo = 3, EName = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp1.Add(new Employee1 { ENo = 4, EName = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp1.Add(new Employee1 { ENo = 5, EName = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp1.Add(new Employee1 { ENo = 6, EName = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp1.Add(new Employee1 { ENo = 7, EName = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp1.Add(new Employee1 { ENo = 8, EName = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static void Main()
        {
            AddRecs1();
            Console.WriteLine("in file");

            string str = "Trying binary ";

            byte[] arr = Encoding.Default.GetBytes(lstEmp1.ToString());

            
            WriteToFile1(arr);
            //ReadFromFile1();
        }

        private static void WriteToFile1(byte[] arr)
        {
            FileStream stream = File.Open("F:\\try\\binaryEmp.dat", FileMode.OpenOrCreate);
            stream.Write(arr, 0, arr.Length);
            stream.Close();
        }
        private static void ReadFromFile1()
        {
            string s;
            StreamReader reader = File.OpenText("F:\\try\\employees2.txt");
            Console.WriteLine("File contains :");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }
    }
    public class Employee1
    {
        public int ENo { get; set; }

        public string EName { get; set; }

        public decimal Basic { get; set; }

        public int DeptNo { get; set; }

        public string Gender { get; set; }

        public override string ToString()
        {
            return EName + " , " + ENo.ToString() + " , " + Basic.ToString() + " , " + DeptNo.ToString();
        }
    }
}