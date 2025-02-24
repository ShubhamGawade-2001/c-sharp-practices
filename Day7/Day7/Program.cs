using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static Employee GetEmps(Employee emp)
        {
            return emp;
        }
        static void Main1()
        {

            AddRecs();
            //var emps = from emp in lstEmp select emp;
            var emps1 = lstEmp.Select(GetEmps);
            var emps2 = lstEmp.Select(delegate (Employee emp)
            {
                return emp;
            });
            var emps = lstEmp.Select(emp => emp);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static int GetEmpNo(Employee emp)
        {
            return emp.EmpNo;
        }
        static void Main2()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp.Name;
            //var emps = from emp in lstEmp select emp.EmpNo;
            var emps3 = lstEmp.Select(GetEmpNo);
            var emps4 = lstEmp.Select(delegate (Employee emp)
            {
                return emp.EmpNo;
            });
            var emps5 = lstEmp.Select(emp => emp.EmpNo);


            foreach (var item in emps5)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();
            var emps0 = from emp in lstEmp select new { emp.EmpNo, emp.Name };
            var emps1 = lstEmp.Select(delegate (Employee emp)
            {
                return new { emp.EmpNo, emp.Name };
            });
            var emps = lstEmp.Select(emp => new { emp.EmpNo, emp.Name });
            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
            }
        }
        static bool IsBasicGreaterThan10000(Employee emp)
        {
            return emp.Basic > 10000;
        }
        static void Main()
        {
            AddRecs();
            //var emps0 = from emp in lstEmp
            //           where emp.Basic > 10000
            //           select emp;

            //var emps1 = lstEmp.Where(IsBasicGreaterThan10000);
            var emps = lstEmp.Where(delegate (Employee emp)
            {
                return emp.Basic > 10000;
            });

            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }

        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
            public string Gender { get; set; }
            public override string ToString()
            {
                string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
                return s;
            }
        }
        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
        }
    }
}
