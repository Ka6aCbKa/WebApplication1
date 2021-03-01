using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStructureEnumTest
{
    class Person
    {
        private string _name;
        public string Name { get { return _name; } private set { _name = value; } }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Имя перса {Name}");
        }
        public virtual void Display2()
        {
            Console.WriteLine($"Имя перса {Name}");
        }
    }
}
