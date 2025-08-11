using HW10.Models;

namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////{
            ////    // Yeni group yaradılır
            ////    Group group = new Group("Programming-101", 3);

            ////    // Student-lər yaradılır
            ////    Student s1 = new Student("Ali", 20);
            ////    Student s2 = new Student("Leyla", 21);
            ////    Student s3 = new Student("Murad", 19);
            ////    Student s4 = new Student("Kamil", 22); // limitdən artıq olacaq

            ////    // Əlavə edirik
            ////    group.Add(s1);
            ////    group.Add(s2);
            ////    group.Add(s3);
            ////    group.Add(s4); // Group full olacaq

            ////    Console.WriteLine();
            ////    group.ShowStudents();

            ////    Console.WriteLine("\nMurad çıxarılır...");
            ////    group.Remove("Murad");
            ////    group.ShowStudents();

            ////    Console.WriteLine("\nLeyla varmı?");
            ////    Console.WriteLine(group.StudentExists("Leyla") ? "Var" : "Yoxdur");
            ////}
            ///



            Employee emp = new Employee
            {
                Name = "Aysel",
                Surname = "Hüseynova",
                Company = "TechSoft",
                SalaryPerHour = 10,
                Hours = 160,
                Experience = 2
            };

            Manager man = new Manager
            {
                Name = "Rauf",
                Surname = "Məmmədov",
                Company = "TechSoft",
                SalaryPerHour = 15,
                Hours = 170,
                Experience = 5,
                Bonus = 10
            };

            Console.WriteLine("Employee:");
            emp.CalculateSalary();

            Console.WriteLine("\nManager:");
            man.CalculateSalary();
        }



    }
    
}
    
