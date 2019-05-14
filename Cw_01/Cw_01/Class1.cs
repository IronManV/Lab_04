using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    public class Person
    {
        private string Name;
        private string Surname;
        private int Age;
        private int Height;

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public int Age1 { get => Age; set => Age = value; }
        protected int Height1 { get => Height; set => Height = value; }

        public void Introdiuce()
        {
            Console.WriteLine("Hi my name is: {0} {1}. I'm {2} years old and {3} height.", Name1, Surname1, Age1, Height1);
        }
    }
}
