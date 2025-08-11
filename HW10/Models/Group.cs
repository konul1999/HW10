////namespace HW10.Models
////{
////    internal class Group
////    {
////            public string Name { get; set; }
////            public int GroupLimit { get; set; }
////            public Student[] Students { get; private set; }

////            public Group(string name, int limit)
////            {
////                Name = name;
////                GroupLimit = limit;
////                Students = new Student[0];
////            }

////            public void Add(Student student)
////            {
////                if (Students.Length < GroupLimit)
////                {
////                    Array.Resize(ref Students, Students.Length + 1);
////                    Students[^1] = student;
////                    Console.WriteLine($"{student.Name} added to group {Name}");
////                }
////                else
////                {
////                    Console.WriteLine($"Group {Name} is full.");
////                }
////            }

////            public void Remove(string studentName)
////            {
////                int index = Array.FindIndex(Students, s => s.Name == studentName);
////                if (index >= 0)
////                {
////                    for (int i = index; i < Students.Length - 1; i++)
////                    {
////                        Students[i] = Students[i + 1];
////                    }
////                    Array.Resize(ref Students, Students.Length - 1);
////                    Console.WriteLine($"{studentName} removed from group {Name}");
////                }
////                else
////                {
////                    Console.WriteLine($"{studentName} not found in {Name}");
////                }
////            }

////            public bool StudentExists(string studentName)
////            {
////                return Array.Exists(Students, s => s.Name == studentName);
////            }

////            public void ShowStudents()
////            {
////                Console.WriteLine($"Group {Name} students:");
////                foreach (var s in Students)
////                {
////                    s.PrintInfo(); // Polymorphism - Student PrintInfo çağırılır
////                }
////            }
////        }
////    }

