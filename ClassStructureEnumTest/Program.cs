using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassStructureEnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTest();


            //VirtualMethodTest();
            //BitmapTest();
            Console.ReadLine();
        }
        public static void LinqTest()
        {
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            List<Phone> phones = new List<Phone>()
            {
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple"},
            };

            //Select many
            //var selectedUsers = users.SelectMany(u => u.Languages, (u, l) => new { User = u, Lang = l }).Where(u => u.Lang == "английский" && u.User.Age < 28).Select(u => u.User);
            var selectedUsers = from u in users
                                from lang in u.Languages
                                where u.Age < 28 && lang == "английский"
                                select u;
            foreach (User use in selectedUsers)
            {
                Console.WriteLine(use.Name);
            }
            Console.WriteLine();

            //Проэкция переменной
            //var usersName = users.Select(u => u.Name);
            var usersName = from u in users
                            select u.Name;
            foreach (string u in usersName)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine();

            //Новый анонимный обьект
            //var newUsers = users.Select(u => new
            //{
            //    Name = u.Name,
            //    DateBirth = DateTime.Now.Year - u.Age
            //});
            var newUsers = from u in users
                           let n = "Mr. " + u.Name
                           select new
                           {
                               Name = n,
                               DateBirth = DateTime.Now.Year - u.Age
                           };
            foreach (var u in newUsers)
            {
                Console.WriteLine($"{u.Name} was born in {u.DateBirth}");
            }
            Console.WriteLine();

            //Выборка с нескольких обьектов
            //var usersPhone = users.SelectMany(u => phones, (u, p) => new { Name = u.Name, Phone = p.Name });
            var usersPhone = from u in users
                             from p in phones
                             select new
                             {
                                 Name = u.Name,
                                 Phone = p.Name
                             };
            foreach (var u in usersPhone)
            {
                Console.WriteLine($"{u.Name} got {u.Phone} mobile");
            }
            Console.WriteLine();

            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            //var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            var selectedTeams = from t in teams
                                where t.ToUpper().StartsWith("Б")
                                orderby t
                                select t;
            foreach (string s in selectedTeams)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
        public static void VirtualMethodTest()
        {
            Person per1 = new Person("Bill");
            per1.Display();
            Employee emp1 = new Employee("Tom", "Apple");
            emp1.Display();
            Client cli1 = new Client("Chel", "Privat");
            cli1.Display();

            Person per2 = new Employee("Clark", "Microsoft");
            per2.Display();
            per2.Display2();

            Employee emp2 = (Employee)per2;
            emp2.Display();

            Employee emp3 = per1 as Employee;
            if (emp3 == null)
            {
                Console.WriteLine("Не верное приведение типов");
            }
            else
            {
                emp3.Display();
            }
        }
        public static void BitmapTest()
        {
            Bitmap arg1 = Bitmap.fifth | Bitmap.first;

            Console.WriteLine(arg1.ToString());

            arg1 ^= Bitmap.fifth;
            Console.WriteLine(arg1.ToString());

            arg1 |= Bitmap.forth | Bitmap.sixth;
            Console.WriteLine(arg1.ToString());

            bool y = (arg1 & Bitmap.sixth) == Bitmap.sixth;
            Console.WriteLine(y);

            y = arg1.HasFlag(Bitmap.eigth);
            Console.WriteLine(y);
            Console.WriteLine();


            BitOperations arg2 = new BitOperations(Bitmap.sixth);
            Console.WriteLine(arg2);

            arg2.Add(Bitmap.seventh | Bitmap.second);
            Console.WriteLine(arg2);

            if (arg2.Contains(Bitmap.second))
            {
                arg2.Remove(Bitmap.second);
            }
            Console.WriteLine(arg2);

            y = arg2.Contains(Bitmap.second);
            Console.WriteLine(y);
        }
    }
}
