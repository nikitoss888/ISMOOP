using System;
using static System.Console;
namespace Students_and_Their_Objects
{
    class Human
    {
        protected string Name, Surname;
        protected int BirthYear, BirthMonth, BirthDay;
        public Human()
        {
            Name = "None";
            Surname = "None";
            BirthDay = 0;
            BirthMonth = 0;
            BirthYear = 0;
        }
        public Human(string name, string surname, int birthDay, int birthMonth, int birthYear)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
        }
        public Human(int birthDay, int birthMonth, int birthYear)
        {
            Name = "Error";
            Surname = "Error";
            BirthDay = birthDay;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
        }
        public Human(Human obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            BirthDay = obj.BirthDay;
            BirthMonth = obj.BirthMonth;
            BirthYear = obj.BirthYear;
        }
        public void SetValueBase()
        {
            Write("Новое имя: "); Name = ReadLine();
            Write("Новая фамилия: "); Surname = ReadLine();
            if (Name.Length < 3 || Surname.Length < 3) 
            {
                do
                {
                    Write("Введите корректные данные. Имя и фамилия не меньше 3 символов.\n");
                    Write("Новое имя: "); Name = ReadLine();
                    Write("Новая фамилия: "); Surname = ReadLine();
                } while (Name.Length < 3 && Surname.Length < 3);
            }
            Write("Новый день рождения: "); BirthDay = int.Parse(ReadLine());
            Write("Новый месяц рождения: "); BirthMonth = int.Parse(ReadLine());
            Write("Новый год рождения: "); BirthYear = int.Parse(ReadLine());
            if (BirthDay < 1 || (BirthDay > 31 && (BirthMonth != 1 || BirthMonth != 3 || BirthMonth != 5 || BirthMonth != 7
                || BirthMonth != 8 || BirthMonth != 10 || BirthMonth != 12)) || (BirthDay > 30 && (BirthMonth != 4 ||
                BirthMonth != 6 || BirthMonth != 9 || BirthMonth != 11)) ||
                (BirthDay > 28 && BirthMonth == 2 && BirthYear % 4 != 0) ||
                (BirthDay > 29 && BirthMonth == 2 && (BirthYear % 4 == 0 && BirthYear % 100 != 0 || BirthYear % 400 == 0))
                && BirthMonth < 1 || BirthMonth > 12 && BirthYear < 1930 || BirthYear > DateTime.Now.Year - 12)
            {
                do
                {
                    Write("Введите корректные значения (учтите високосные года и февраль).\n");
                    Write("Новый день рождения: "); BirthDay = int.Parse(ReadLine());
                    Write("Новый месяц рождения: "); BirthMonth = int.Parse(ReadLine());
                    Write("Новый год рождения: "); BirthYear = int.Parse(ReadLine());
                } while (BirthDay < 1 || (BirthDay > 31 && (BirthMonth != 1 || BirthMonth != 3 || BirthMonth != 5 || BirthMonth != 7
                || BirthMonth != 8 || BirthMonth != 10 || BirthMonth != 12)) || (BirthDay > 30 && (BirthMonth != 4 ||
                BirthMonth != 6 || BirthMonth != 9 || BirthMonth != 11)) ||
                (BirthDay > 28 && BirthMonth == 2 && BirthYear % 4 != 0) ||
                (BirthDay > 29 && BirthMonth == 2 && (BirthYear % 4 == 0 && BirthYear % 100 != 0 || BirthYear % 400 == 0))
                && BirthMonth < 1 || BirthMonth > 12 && BirthYear < 1930 || BirthYear > DateTime.Now.Year - 12);
            }
        }
        public void ReadValueBase()
        {
            Write("\nИмя: {0}\nФамилия: {1}\nДата рождения: {2}.{3}.{4}\n", Name, Surname, BirthDay, BirthMonth, BirthYear);
        }
    }
    class Enrollee : Human
    {
        protected int ZNOPoints1, ZNOPoints2, ZNOPoints3, EdDocumentPoints;
        protected string SecSchoolName;
        public Enrollee() : base()
        {
            ZNOPoints1 = 0;
            ZNOPoints2 = 0;
            ZNOPoints3 = 0;
            EdDocumentPoints = 0;
            SecSchoolName = "None";
        }
        public Enrollee(string name, string surname, int birthDay, int birthMonth, int birthYear,
            int znoPoints1, int znoPoints2, int znoPoints3, int edDocumentPoints, string secSchoolName) 
            : base(name, surname, birthDay, birthMonth, birthYear)
        {
            ZNOPoints1 = znoPoints1;
            ZNOPoints2 = znoPoints2;
            ZNOPoints3 = znoPoints3;
            EdDocumentPoints = edDocumentPoints;
            SecSchoolName = secSchoolName;
        }
        public Enrollee(int birthDay, int birthMonth, int birthYear, int znoPoints1, int znoPoints2, int znoPoints3, 
            int edDocumentPoints) : base(birthDay, birthMonth, birthYear)
        {
            ZNOPoints1 = znoPoints1;
            ZNOPoints2 = znoPoints2;
            ZNOPoints3 = znoPoints3;
            EdDocumentPoints = edDocumentPoints;
            SecSchoolName = "Error";
        }
        public Enrollee(Enrollee obj) : base(obj)
        {
            ZNOPoints1 = obj.ZNOPoints1;
            ZNOPoints2 = obj.ZNOPoints2;
            ZNOPoints3 = obj.ZNOPoints3;
            EdDocumentPoints = obj.EdDocumentPoints;
            SecSchoolName = obj.SecSchoolName;
        }
        public void SetValue()
        {
            SetValueBase();
            Write("Новые балы ВНО/ЗНО за 1 сертификат: "); ZNOPoints1 = int.Parse(ReadLine());
            if (ZNOPoints1 < 0 || ZNOPoints1 > 200)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новые балы ВНО/ЗНО: "); ZNOPoints1 = int.Parse(ReadLine());
                } while (ZNOPoints1 < 0 || ZNOPoints1 > 200);
            }
            Write("Новые балы ВНО/ЗНО за 2 сертификат: "); ZNOPoints2 = int.Parse(ReadLine());
            if (ZNOPoints2 < 0 || ZNOPoints2 > 200)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новые балы ВНО/ЗНО: "); ZNOPoints2 = int.Parse(ReadLine());
                } while (ZNOPoints2 < 0 || ZNOPoints2 > 200);
            }
            Write("Новые балы ВНО/ЗНО за 3 сертификат: "); ZNOPoints3 = int.Parse(ReadLine());
            if (ZNOPoints3 < 0 || ZNOPoints3 > 200)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новые балы ВНО/ЗНО: "); ZNOPoints3 = int.Parse(ReadLine());
                } while (ZNOPoints3 < 0 || ZNOPoints3 > 200);
            }
            Write("Новые балы документа об образовании: "); EdDocumentPoints = int.Parse(ReadLine());
            if (EdDocumentPoints < 0 || EdDocumentPoints > 12)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новые балы документа об образовании: "); EdDocumentPoints = int.Parse(ReadLine());
                } while (EdDocumentPoints < 0 || EdDocumentPoints > 12);
            }
            Write("Новое название общедоступного учебного заведения (школа/лицей/...): "); SecSchoolName = ReadLine();
            if (SecSchoolName.Length < 2)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новое название общедоступного учебного заведения (школа/лицей/...): "); SecSchoolName = ReadLine();
                } while ((SecSchoolName.Length < 2));
            }
        }
        public void ReadValue()
        {
            ReadValueBase();
            WriteLine("Балы ВНО/ЗНО: {0}, {1}, {2}\nБалы документа об образовании: {3}\n" +
                "Название общедоступного учебного заведения (школа/лицей/...): {4}\n", ZNOPoints1, ZNOPoints2, ZNOPoints3, EdDocumentPoints, SecSchoolName);
        }
    }
    class Student : Human
    {
        protected string Group, Faculty, HigherEdInst;
        protected int Course;
        public Student() : base()
        {
            Course = 0;
            Group = "None";
            Faculty = "None";
            HigherEdInst = "None";
        }
        public Student(string name, string surname, int birthDay, int birthMonth, int birthYear, int course,
            string group, string faculty, string higherEdInst) : base(name, surname, birthDay, birthMonth, birthYear)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HigherEdInst = higherEdInst;
        }
        public Student(int birthDay, int birthMonth, int birthYear, int course) : base(birthDay, birthMonth, birthYear)
        {
            Course = course;
            Group = "Error";
            Faculty = "Error";
            HigherEdInst = "Error";
        }
        public Student(Student obj) : base(obj)
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            HigherEdInst = obj.HigherEdInst;
        }
        public void SetValue()
        {
            SetValueBase();
            Write("Новый курс: "); Course = int.Parse(ReadLine());
            if (Course < 0 || Course > 5)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новый курс: "); Course = int.Parse(ReadLine());
                } while (Course < 0 || Course > 5);
            }
            Write("Новая группа: "); Group = ReadLine();
            Write("Новый факультет: "); Faculty = ReadLine();
            Write("Новое учебное заведение"); HigherEdInst = ReadLine();
            if (HigherEdInst.Length < 2)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новое учебное заведение"); HigherEdInst = ReadLine();
                } while ((HigherEdInst.Length < 2));
            }
        }
        public void ReadValue()
        {
            ReadValueBase();
            WriteLine("Курс: {0}\nГруппа: {1}\nФакультет: {2}\nУчебное заведение: {3}\n", Course, Group, Faculty, HigherEdInst);
        }
    }
    class Teacher : Human
    {
        protected string Position, Cathedra, HigherEdInst;
        public Teacher() : base()
        {
            Position = "None";
            Cathedra = "None";
            HigherEdInst = "None";
        }
        public Teacher(string name, string surname, int birthDay, int birthMonth, int birthYear, string position,
            string cathedra, string higheredinst) : base(name, surname, birthDay, birthMonth, birthYear)
        {
            Position = position;
            Cathedra = cathedra;
            HigherEdInst = higheredinst;
        }
        public Teacher(int birthDay, int birthMonth, int birthYear) : base(birthDay, birthMonth, birthYear)
        {
            Position = "Error";
            Cathedra = "Error";
            HigherEdInst = "Error";
        }
        public Teacher(Teacher obj) : base(obj)
        {
            Position = obj.Position;
            Cathedra = obj.Cathedra;
            HigherEdInst = obj.HigherEdInst;
        }
        public void SetValue()
        {
            SetValueBase();
            Write("Новая должность: "); Position = ReadLine();
            Write("Новая кафедра: "); Cathedra = ReadLine();
            Write("Новое учебное заведение: "); HigherEdInst = ReadLine();
            if (HigherEdInst.Length < 2)
            {
                do
                {
                    Write("Введите корректные данные.\n");
                    Write("Новое учебное заведение"); HigherEdInst = ReadLine();
                } while ((HigherEdInst.Length < 2));
            }
        }
        public void ReadValue()
        {
            ReadValueBase();
            WriteLine("Должность: {0}\nКафедра: {1}\nУчебное заведение: {2}\n", Position, Cathedra, HigherEdInst);
        }
    }
    class LibraryUser : Human
    {
        protected int Number, StartYear, StartMonth, StartDay, Fee;
        public LibraryUser() : base()
        {
            Number = 0;
            StartDay = 0;
            StartMonth = 0;
            StartYear = 0;
            Fee = 0;
        }
        public LibraryUser(string name, string surname, int birthDay, int birthMonth, int birthYear, int number,
            int startDay, int startMonth, int startYear, int fee) : base(name, surname, birthDay, birthMonth, birthYear)
        {
            Number = number;
            StartDay = startDay;
            StartMonth = startMonth;
            StartYear = startYear;
            Fee = fee;
        }
        public LibraryUser(int birthDay, int birthMonth, int birthYear,
            int startDay, int startMonth, int startYear) : base(birthDay, birthMonth, birthYear)
        {
            Number = 0;
            StartDay = startDay;
            StartMonth = startMonth;
            StartYear = startYear;
            Fee = 0;
        }
        public LibraryUser(LibraryUser obj) : base(obj)
        {
            Number = obj.Number;
            StartDay = obj.StartDay;
            StartMonth = obj.StartMonth;
            StartYear = obj.StartYear;
            Fee = obj.Fee;
        }
        public void SetValue()
        {
            SetValueBase();
            Write("Новый номер билета: "); Number = int.Parse(ReadLine());
            Write("Новый день выдачи: "); StartDay = int.Parse(ReadLine());
            Write("Новый месяц выдачи: "); StartMonth = int.Parse(ReadLine());
            Write("Новый год выдачи: "); StartYear = int.Parse(ReadLine());
            if (StartDay < 1 || (StartDay > 31 && (StartMonth != 1 || StartMonth != 3 || StartMonth != 5 || StartMonth != 7
    || StartMonth != 8 || StartMonth != 10 || StartMonth != 12)) || (StartDay > 30 && (StartMonth != 4 ||
    StartMonth != 6 || StartMonth != 9 || StartMonth != 11)) ||
    (StartDay > 28 && StartMonth == 2 && StartYear % 4 != 0) ||
    (StartDay > 29 && StartMonth == 2 && (StartYear % 4 == 0 && StartYear % 100 != 0 || StartYear % 400 == 0))
    && StartMonth < 1 || StartMonth > 12 && StartYear < 1930 || BirthYear > DateTime.Now.Year - 12)
            {
                do
                {
                    Write("Введите корректные значения (учтите високосные года и февраль).\n");
                    Write("Новый день выдачи: "); StartDay = int.Parse(ReadLine());
                    Write("Новый месяц выдачи: "); StartMonth = int.Parse(ReadLine());
                    Write("Новый год выдачи: "); StartYear = int.Parse(ReadLine());
                } while (StartDay < 1 || (StartDay > 31 && (StartMonth != 1 || StartMonth != 3 || StartMonth != 5 || StartMonth != 7
                || StartMonth != 8 || StartMonth != 10 || StartMonth != 12)) || (StartDay > 30 && (StartMonth != 4 ||
                StartMonth != 6 || StartMonth != 9 || StartMonth != 11)) ||
                (StartDay > 28 && StartMonth == 2 && StartYear % 4 != 0) ||
                (StartDay > 29 && StartMonth == 2 && (StartYear % 4 == 0 && StartYear % 100 != 0 || StartYear % 400 == 0))
                && StartMonth < 1 || StartMonth > 12 && StartYear < 1930 || BirthYear > DateTime.Now.Year - 12);
            }
            Write("Новый размер ежемесячного взноса: "); Fee = int.Parse(ReadLine());
        }
        public void ReadValue()
        {
            ReadValueBase();
            WriteLine("Номер билета читателя: {0}\nДата выдачи: {1}.{2}{3}\nЕжемесячный взнос: {4}\n"
                , Number, StartDay, StartMonth, StartYear, Fee);
        }

    }
    class HSTL
    {
        static void Main(string[] args)
        {
            string name, surname, position, cathedra, higheredinst, secshoolname, group, faculty;
            int birthday, birthmonth, birthyear, zno1, zno2, zno3, educdocum, course, number, startday, startmonth, startyear, fee;
            name = "Виталий"; surname = "Граб"; position = "Ректор"; cathedra = "Математический Анализ"; higheredinst = "ДУ\"ЖП\"";
            birthday = 1; birthmonth = 1; birthyear = 1980;
            Teacher Vi_Grab = new Teacher(name, surname, birthday, birthmonth, birthyear, position, cathedra, higheredinst);
            Vi_Grab.ReadValue();
            name = "Владимир"; surname = "Поливайко"; secshoolname = "ЗОШ №5";
            birthday = 3; birthmonth = 4; birthyear = 2001; zno1 = 160; zno2 = 189; zno3 = 177; educdocum = 12;
            Enrollee Vl_Pol = new Enrollee(name,surname,birthday,birthmonth,birthyear,zno1,zno2,zno3,educdocum,secshoolname);
            Vl_Pol.ReadValue();
            name = "Ярослав"; surname = "Демченко"; group = "ИПЗ-19-2";  faculty = "ФИКТ"; higheredinst = "ДУ\"ЖП\"";
            birthday = 8; birthmonth = 12; birthyear = 2001; course = 1;
            Student Ya_De = new Student(name, surname, birthday, birthmonth, birthyear, course, group, faculty, higheredinst);
            Ya_De.ReadValue();
            name = "Оля"; surname = "Горькая";
            birthday = 31; birthmonth = 10; birthyear = 2004; number = 880035; startday = 20; startmonth = 10; startyear = 2019; fee = 50;
            LibraryUser Olya_Go = new LibraryUser(name,surname,birthday,birthmonth,birthyear,number,startday,startmonth,startyear,fee);
            Olya_Go.ReadValue();
            WriteLine("Предлагаю изменить пару полей юзера...\n1 - ректор\n2 - абитуриента\n3 - студента" +
                "\n4 - посетительницы библиотеки\n0 - отказ и выход.\n");
            int n;
            do {
                n = int.Parse(ReadLine());
                switch (n) {
                    case 1:
                        Vi_Grab.SetValue();
                        Vi_Grab.ReadValue();
                        Write("Ещё-раз? С вас число.\t");
                        break;
                    case 2:
                        Vl_Pol.SetValue();
                        Vl_Pol.ReadValue();
                        Write("Ещё-раз? С вас число.\t");
                        break;
                    case 3:
                        Ya_De.SetValue();
                        Ya_De.ReadValue();
                        Write("Ещё-раз? С вас число.\t");
                        break;
                    case 4:
                        Olya_Go.SetValue();
                        Olya_Go.ReadValue();
                        Write("Ещё-раз? С вас число.\t");
                        break;
                    case 0:
                        WriteLine("До свидания!");
                        break;
                    default:
                        WriteLine("Введите значения от 1 до 4 или 0 для выходаю");
                        break;
                }
            } while (Convert.ToBoolean(n));
            ReadKey();
        }
    }
}