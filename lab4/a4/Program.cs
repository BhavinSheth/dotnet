using System;

namespace a4
{
    public class Program
    {
        public static void Main(string[] st)
        {
            Employee e1 = new Employee("bhavin", "sheth", 450000);
            Employee e2 = new Employee("rahul", "gandhi", 4000);

            Console.WriteLine("Before Increament...");
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());

            Console.WriteLine("After Increament...");
            e1.giveRaise(10.0);
            e2.giveRaise(10.0);

            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());


            PermanentEmployee pe1 = new PermanentEmployee("bhavin", "sheth", 45000, 2000, 1000, 4500, "01-02-2022", "10-05-2022");

            PermanentEmployee pe2 = new PermanentEmployee("rahul", "gandhi", 23000, 2789, 500, 9500, "01-01-2022", "18-12-2022");

            Console.WriteLine("Before Increament...");

            Console.WriteLine(pe1);
            Console.WriteLine(pe2);

            pe1.giveRaise(10.0);
            pe2.giveRaise(10.0);

            Console.WriteLine("After Increament...");

            Console.WriteLine(pe1.ToString());
            Console.WriteLine(pe2.ToString());
        }
    }

    public class Employee
    {
        private String _firstName;
        private String _lastName;
        private double _nonSalary;

        public Employee(String first, String last, double sal)
        {
            _firstName = first;
            _lastName = last;
            _nonSalary = sal < 0 ? 0.0 : sal;
        }

        public String First
        {
            get => _firstName;
            set => _firstName = value;
        }
        public String Last
        {
            get => _lastName;
            set => _lastName = value;
        }

        public double NonSalary
        {
            get => _nonSalary;
            set => _nonSalary = value < 0 ? 0.0 : value;
        }

        public virtual void giveRaise(double inc)
        {
            _nonSalary = _nonSalary + (_nonSalary * inc / 100);
        }

        public override string ToString()
        {
            return "Employee Details : " + _firstName + " " + _lastName + " Yearly Salary : " + (_nonSalary) * 12;
        }
    }

    public class PermanentEmployee : Employee
    {

        private double _hra;
        private double _da;
        private double _pf;
        private String _joiningDate;
        private String _retirementDate;

        public PermanentEmployee(String first, String last, double sal, double hra, double da, double pf, String joiningDate, String retirementDate) : base(first, last, sal)
        {
            this._hra = hra;
            this._da = da;
            this._pf = pf;
            this._joiningDate = joiningDate;
            this._retirementDate = retirementDate;
            this.NonSalary = this.NonSalary + _hra + _da;
        }

        public double Hra
        {
            get => _hra;
        }

        public double Da
        {
            get => _da;
        }

        public double Pf
        {
            get => _pf;
        }

        public String JoiningDate
        {
            get => _joiningDate;
            set => _joiningDate = value;
        }

        public String RetirementDate
        {
            get => _retirementDate;
            set => _retirementDate = value;
        }

        public override void giveRaise(double inc)
        {
            this.NonSalary = this.NonSalary + (this.NonSalary * inc) / 100 + _da + _hra;
        }

        public override string ToString()
        {
            return "Permanent Employee Details : " + this.First + " " + this.Last + " Joining Date : " + _joiningDate + " Retirement Date : " + _retirementDate + " Yearly Salary : " + (this.NonSalary) * 12;
        }
    }
}