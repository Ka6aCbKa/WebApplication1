using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStructureEnumTest
{
    class Client: Person
    {
        private string _bank;
        public string Bank { get { return _bank; } private set { _bank = value; } }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
        public new void Display()
        {
            Console.WriteLine($"Клиента зовут {Name}. У него открыт счет в {Bank}");
        }
        public override void Display2()
        {
            Console.WriteLine($"Клиента зовут {Name}. У него открыт счет в {Bank}");
        }
    }
}
