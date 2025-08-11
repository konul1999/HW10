using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    internal class Manager : Employee
    {
        public decimal Bonus { get; set; } // faizlə

        public Manager(string name, string surname, string company, decimal salaryPerHour, int hours, int experience, decimal bonus)
            : base(name, surname, company, salaryPerHour, hours, experience)
        {
            Bonus = bonus;
        }

        public override void CalculateSalary()
        {
            decimal baseSalary = SalaryPerHour * Hours;
            decimal totalSalary = baseSalary + (baseSalary * Bonus / 100);
            Console.WriteLine($"{ToString()} earns {totalSalary} from {Company} (includes {Bonus}% bonus)");
        }
    }
}
}
