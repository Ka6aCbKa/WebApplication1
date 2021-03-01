using System;

namespace ClassStructureEnumTest
{    
    class Program
    {
        
        static void Main(string[] args)
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



            Console.WriteLine();
            //Bitmap test
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
            Console.ReadLine();
        }
    }
}
