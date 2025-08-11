using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    internal class Employee : Person
    {
        public string Company { get; set; }
        public decimal SalaryPerHour { get; set; }
        public int Hours { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string surname, string company, decimal salaryPerHour, int hours, int experience)
            : base(name, surname)
        {
            Company = company;
            SalaryPerHour = salaryPerHour;
            Hours = hours;
            Experience = experience;
        }

        // Virtual metod – Manager-də override ediləcək
        public virtual void CalculateSalary()
        {
            decimal salary = SalaryPerHour * Hours;
            Console.WriteLine($"{ToString()} earns {salary} from {Company}");
        }
    }
}
