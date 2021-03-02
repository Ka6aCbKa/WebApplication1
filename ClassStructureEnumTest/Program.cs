﻿using System;
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

            var selectedUsers = users.SelectMany(u => u.Languages, (u, l) => new { User = u, Lang = l }).Where(u => u.Lang == "английский" && u.User.Age < 28).Select(u => u.User);
            foreach (User use in selectedUsers)
            {
                Console.WriteLine(use.Name);
            }

            Console.WriteLine();
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
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
