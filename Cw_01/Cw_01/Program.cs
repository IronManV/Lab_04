using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    public class Person1
    {
        public string Name;
        public void Introuce(string to)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name1 = "Pablo";
            person.Surname1 = "Gawino";
            person.Age1 = 20;
            

            person.Introdiuce();

            Console.ReadKey();
        }
    }
   
}
