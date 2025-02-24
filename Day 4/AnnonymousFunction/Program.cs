using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action o1 = delegate()
             {
                Console.WriteLine("hii");
            };
            Func<int, int> o3 = a => a * 2;
            Func<int,int,int > addO = (a,b)=> a + b;
            addO(10, 20);

        
            }
        }
    }
}
