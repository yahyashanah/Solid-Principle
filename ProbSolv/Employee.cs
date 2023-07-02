using System;
using System.Collections.Generic;
using System.Text;

namespace ProbSolv
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        public abstract decimal CalcHourBouns(decimal hours);

        public override string ToString()
        {
            return $"Employee Id: {ID}, Name: {Name}";
        }
    }

    public class Manager : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        public decimal CalcHourBonus(decimal hours)
        {
            return (((BasicSalary / 30) / 8) * hours) * 2;
        }
        public override string ToString()
        {
            return $"Employee Id: {ID}, Name: {Name}";
        }

    }

    public class RegularEmp : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal CalcHourBonus(decimal hours)
        {
            return ((BasicSalary / 30) / 8) * hours;
        }

        public override string ToString()
        {
            return $"Employee Id: {ID}, Name: {Name}";
        }
    }
}
