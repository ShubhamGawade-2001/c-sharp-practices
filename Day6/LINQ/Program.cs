using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
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


        static void Main1()
        {
            AddRecs();
            var emps = from emp
                       in lstEmp
                       select emp;
            foreach (var i in emps)
            {
                Console.WriteLine(i);
            }

        }
        static void Main()
        {
            AddRecs();

            //var emps = from emp
            //           in lstEmp
            //           select emp.Name;
            //foreach (var i in emps)
            //{
            //    Console.WriteLine(i);
            //}

            //var emps2 = from emp
            //            in lstEmp
            //            select new { emp.Name, emp.DeptNo };
            //foreach (var item in emps2)
            //{
            //    Console.WriteLine(item);
            //}

            //var emps3 = from emp in lstEmp
            //            where emp.Basic >10000
            //            select emp;
            //foreach (var item in emps3)
            //{
            //    Console.WriteLine(item.Name +" "+ item.Basic);
            //}

            //var emps4 = from emp in lstEmp
            //            join dept in lstDept
            //            on emp.DeptNo equals dept.DeptNo
            //            select new { emp, dept };
            //foreach (var item in emps4)
            //{
            //    Console.Write(item.emp.Name+"  ");
            //    Console.WriteLine(item.dept.DeptName);
            //}

            //var deptEmployeeCount = from dept in lstDept
            //                        join emp in lstEmp
            //                        on dept.DeptNo equals emp.DeptNo
            //                        into empGroup
            //                        select new
            //                        {
            //                            dept.DeptName, empGroup
            //                        };
            //foreach (var result in deptEmployeeCount)
            //{
            //    Console.WriteLine($"{result.DeptName}: {result.empGroup.Count()} employees");
            //}


            //var empWorks = from emp in lstEmp
            //               join dept in lstDept
            //               on emp.DeptNo equals dept.DeptNo
            //               where dept.DeptName == "MKTG"
            //               select emp;
            //foreach (var i in empWorks)
            //{
            //    Console.WriteLine(i.Name);
            //}

            //var salHigh = from emp in lstEmp
            //              join dept in lstDept
            //              on emp.DeptNo equals dept.DeptNo
            //              group emp by dept.DeptNo into deptGroup
            //              select new { 
            //                deptGroup.Key
            //              }


        }
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
    public class  Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }


}
