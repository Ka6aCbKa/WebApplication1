using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStructureEnumTest
{
    class Employee : Person
    {
        private string _company;
        public string Company { get { return _company; } private set { _company = value; } }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"Работника зовут {Name}. Работает в компании {Company}");
        }
        public override void Display2()
        {
            Console.WriteLine($"Работника зовут {Name}. Работает в компании {Company}");
        }
    }
}
