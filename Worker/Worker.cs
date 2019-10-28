using static System.Console;
using System;
namespace Worker
{
    class Company
    {
        protected string Name_co, Position;
        protected int Salary;
        public Company()
        {
            Name_co = "None";
            Position = "None";
            Salary = 0;
        }
        public Company(string name_co)
        {
            Name_co = name_co;
            Position = "Assistant";
            Salary = 5000;
        }
        public Company(string name_co, string position, int salary)
        {
            Name_co = name_co;
            Position = position;
            Salary = salary;
        }
        public void Set(string name_co, string position, int salary)
        {
            Name_co = name_co;
            Position = position;
            Salary = salary;

        }

    }
    class Worker
    {
        protected string Name;
        protected int Year, Month;
        protected Company Workplace = new Company();
        public Worker()
        {
            Set("None", "None", 0, "None", DateTime.Now.Year, DateTime.Now.Month);
        }
        public Worker(string name_co, string name)
        {
            Set(name_co, "Assistant", 5000, name, DateTime.Now.Year, DateTime.Now.Month - 1);
        }
        public Worker(string name_co, string position, int salary, string name, int year, int month)
        {
            Set(name_co, position, salary, name, year, month);
        }
        public void Set(string name_co, string position, int salary, string name, int year, int month)
        {
            Name = name;
            Year = year;
            Month = month;
            Company Workplace = new Company();
            Workplace.Set(name_co, position, salary);
        }
        public void Get()
        {
            int exp, totmon;
            GetWorkExperience(out exp);
            GetTotalMoney(out totmon, exp);
            WriteLine("\nКомпания: {0}\nДолжность: {1}\nЗ/п: {2}\nИмя работника: {3}\nГод зачисления на работу: {4}\n" +
                "Месяц зачисления на работу: {5}\nСтаж роботы: {6}\nВсего заработано: {7}", 
                Workplace, Workplace, Workplace, Name, Year, Month, exp, totmon);

        }
        public void GetWorkExperience(out int exp)
        {
            exp = (DateTime.Now.Year - Year) * 12 + (DateTime.Now.Month - Month);
        }
        public void GetTotalMoney(out int totalmoney, int exp)
        {
            totalmoney = exp * ;
        }
    }
    class Program
    {
        static void Main()
        {
            ReadWorkersArray();
            WriteLine("Выберите нужную операцию с данными работников:" +
                "\n1 - вывести информацию о некотором работнике\n2 - вывести информацию о всех работниках\n" +
                "3 - вывести самую большую и свмую маленькую зарплаты\n4 - вывести рассортированный по уменьшению зарплаты список работников\n" +
                "5 - вывести рассортированный по росту стажа список работников");
            ReadLine();
        }
        static void ReadWorkersArray()
        {
            int a, n, salary, year, month; string name_co, position, name;
            Write("Количество работников: "); n = int.Parse(ReadLine());
            Worker[] workers = new Worker[n];
            WriteLine("Введите данные работников.");
            for (int i = 0; i < n; i++)
            {
                Write("Компания: "); name_co = ReadLine();
                Write("Должность: "); position = ReadLine();
                Write("З/п: "); salary = int.Parse(ReadLine());
                Write("Имя работника: "); name = ReadLine();
                Write("Год зачисления на работу: "); year = int.Parse(ReadLine());
                Write("Месяц зачисления на работу: "); month = int.Parse(ReadLine());
                Write("Выберите способ ввода данных в экземпляр класса:\n" +
                    "1 - метод Set\n2 - конструктор");
                do {
                    switch (a = int.Parse(ReadLine()))
                    {
                        case 1:
                            workers[i].Set(name_co, position, salary, name, year, month);
                            break;
                        case 2:
                            if (name.Length == 1 || name_co.Length == 1)
                            {
                                workers[i] = new Worker();
                            }
                            else if (position.Length == 1 || salary == 0)
                            {
                                workers[i] = new Worker(name_co, name);
                            }
                            else
                                workers[i] = new Worker(name_co, position, salary, name, year, month);
                            break;
                        default:
                            {
                                WriteLine("Было введено неправильное чило, введите 1 или 2.");
                                break;
                            }
                    }
                } while (a != 1 || a != 2);
            }
        }
    }
}
