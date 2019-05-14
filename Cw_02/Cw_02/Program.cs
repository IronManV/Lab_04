using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pablo";
            person.Surname = "Gawin";
            person.Age = 20;

            person.Intorduce();
            Employee employee = new Employee();
            employee.hourlyRate = 20;

            Console.WriteLine(employee.Reward(80));

            Console.ReadKey();
        }
    }
}
