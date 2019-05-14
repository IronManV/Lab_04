using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_04
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        private int height;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        protected int Height { get => height; set => height = value; }

        public void Intorduce()
        {
            Console.WriteLine("Hi my name is: {0} {1}. I'm {2} years old and {3} height.", Name, Surname, Age, Height);
        }

    }
    class Employee : Person
    {
        public string position;
        public int hourlyRate;
        public string[,] employeeArray = new string[5, 2]; 

        public int Reward(int hours)
        {
            return hours * hourlyRate;
        }
    }
}
