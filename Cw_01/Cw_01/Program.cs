using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human();
            person1.name = "John";
            person1.surname = "Kowalski";
            Console.WriteLine(person1.name);

            Human person2 = new Human();
            person2.name = "Elizabeth";
            person2.surname = person1.surname;
        }
        class Human
        {
            public string name, surname;
            public int age;
            public int height;
        }
    }
}
