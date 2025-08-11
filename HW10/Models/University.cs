

////namespace HW10.Models
////{
////    internal class University
////    {
////        public string Name { get; set; }
////        public Group[] Groups { get; private set; }

////        public University(string name)
////        {
////            Name = name;
////            Groups = new Group[0];
////        }

////        public void AddGroup(Group group)
////        {
////            Array.Resize(ref Groups, Groups.Length + 1);
////            Groups[^1] = group;
////            Console.WriteLine($"Group {group.Name} added to university {Name}");
////        }

////        public void RemoveGroup(string groupName)
////        {
////            int index = Array.FindIndex(Groups, g => g.Name == groupName);
////            if (index >= 0)
////            {
////                for (int i = index; i < Groups.Length - 1; i++)
////                {
////                    Groups[i] = Groups[i + 1];
////                }
////                Array.Resize(ref Groups, Groups.Length - 1);
////                Console.WriteLine($"Group {groupName} removed from university {Name}");
////            }
////            else
////            {
////                Console.WriteLine($"Group {groupName} not found.");
////            }
////        }

////        public void ShowGroups()
////        {
////            Console.WriteLine($"University {Name} groups:");
////            foreach (var g in Groups)
////            {
////                Console.WriteLine($"- {g.Name}");
////            }
////        }

////        public void ShowAllStudents()
////        {
////            Console.WriteLine($"All students in {Name}:");
////            foreach (var g in Groups)
////            {
////                g.ShowStudents();
////            }
////        }
////    }
////}

