using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            Employee person1 = new Employee();
            Employee person2 = new Employee();

            person.WriteEmployeeNumber();
            
            Console.ReadKey();   
        }
        
    }
}
