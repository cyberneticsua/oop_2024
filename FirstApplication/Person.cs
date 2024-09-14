namespace HelloApp
{
    //<модифікатори доступу> class ClassName
    //{
    //    //fields;
    //    <модифікатори доступу> <тип даних> variableName;
    //    //member methods;

    //    <модифікатори доступу> <тип даних, що повертається> Method1(parameter_list)
    //    {method body };
    //    }
    class Person
    {
        string name;
        double salary;
        protected int birthYear;
        //static
        //const
        public static double bonus;
        public const double f = 33;
        public readonly double t1;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }


            }
        }
        public string SecondName { get; set; }

        public Person(string name, double salary, int birthYear, double t1)
        {
            this.name = name;
            this.Salary = salary;
            this.birthYear = birthYear;
            this.t1 = t1;
        }
        public Person() : this("Noname", 500, 2000, 500)
        {
        }
        public Person(string name) : this(name, 500, 2000, 500)
        {
        }
        public Person(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
            this.birthYear = 2000;
            this.t1 = 500;
        }

        public string GetInformation()
        {
            if (this.SecondName == "")
            {
                return $"Name: {this.Name}, Surname: {this.Surname}";
            }
            return $"Name: {this.Name}, SecondName: {this.SecondName}, Surname: {this.Surname}";
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name: {this.Name}, Surname: {this.Surname}");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class SuperPerson : Person
    {
        string SuperPower;

        public SuperPerson(string name, double salary, int birthYear, string superPower) : base(name, salary, birthYear, 255)
        {
            this.SuperPower = superPower;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Petro");
            Person p3 = new Person("Petro", 555);
            Person p4 = new Person("Petro", 555, 2024, 2.5);
            p1.Name = "dfsfs";
            p1.Salary = -1000;
            p1.Add(3, 4);
            int r = p1.Add(1, 2, 3);
            Console.WriteLine(p1.GetInformation());
            p1.PrintInformation();
            int i = 0;
            Person.bonus += 300;

        }
    }
}
