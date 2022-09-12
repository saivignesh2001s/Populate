using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populate
{
    public interface Info
    {
        string getTypeOfPerson();
    }
    public class Students:Info
    {
        private string _sname;
        public string SName
        {
            get;
            set;
        }
        private string _sclass;
        public string SClass
        {
            get;
            set;
        }
       
       
        public void Adding(string k,List<Students> m)
        {
            Students students = new Students();
            students.SName = k;
            Console.WriteLine("Enter the class and section for student");
            students.SClass = Console.ReadLine();
            m.Add(students);

        }
        public void Removal(string p,List<Students> m)
        {
            var pk = m.Where(list => list.SName == p).ToList();
            if (pk.Count == 1)
            {
                m.Remove(pk[0]);
            }
            else
            {
                DisplayStudents(m);
                Console.WriteLine("Enter the class and section of a {0} to delete",p);
                string hk = Console.ReadLine();
                var hks=pk.Where(list=>list.SClass == hk).ToList();
                foreach(var item in hks)
                {
                    m.Remove(item);
                }

            }
           
        }
        public void DisplayStudents(List<Students> m)
        {
            Console.WriteLine("Students List");
            foreach(var item in m)
            {
                Console.Write($"{item.SName}  {item.SClass}");
                Console.Write("\n");
            }

        }

        public string getTypeOfPerson()
        {
            return "Student";
        }
    }
    public class Teachers:Info
    {
        public string TName
        {
            get;
            set;
        }
        public string TClass
        {
            get;
            set;
        }
        public string Sub
        {
            get;
            set;
        }
        public void Adding(string k, List<Teachers> m)
        {
            Teachers teacher= new Teachers();
            teacher.TName = k;
            Console.WriteLine("Enter the class and section for teacher");
            teacher.TClass = Console.ReadLine();
            Console.WriteLine("Subject handling of a teacher");
            teacher.Sub = Console.ReadLine();
            m.Add(teacher);

        }
        public void Removal(string p, List<Teachers> m)
        {
            var pk = m.Where(list => list.TName == p).ToList();
            if (pk.Count == 1)
            {
                m.Remove(pk[0]);
            }
            else
            {
                Displayteachers(m);
                Console.WriteLine("Enter the class and section of a {0} to delete", p);
                string hk = Console.ReadLine();
                var hks = pk.Where(list => list.TClass == hk).ToList();
                foreach (var item in hks)
                {
                    m.Remove(item);
                }

            }

        }
        public void Displayteachers(List<Teachers> m)
        {
            Console.WriteLine("Teachers List");
            foreach (var item in m)
            {
                Console.Write($"{item.TName}  {item.TClass} {item.Sub}");
                Console.Write("\n");
            }

        }

        public string getTypeOfPerson()
        {
            return "Teacher";
        }
    }
    public class Subjects
    {
        public string SubName
        {
            get;
            set;
        }
        public string SubCode
        {
            get;
            set;
        }
        public void Adding(string k, List<Subjects> m)
        {
            Subjects teacher = new Subjects();
            teacher.SubName = k;
            Console.WriteLine("Enter the sub code for subject");
            teacher.SubCode = Console.ReadLine();
            m.Add(teacher);

        }
        public void Removal(string p, List<Subjects> m)
        {
            var pk = m.Where(list => list.SubName == p).ToList();
            if (pk.Count == 1)
            {
                m.Remove(pk[0]);
            }
            else
            {
                DisplaySubjects(m);
                Console.WriteLine("Enter the Subject code {0} to delete", p);
                string hk = Console.ReadLine();
                var hks = pk.Where(list => list.SubCode == hk).ToList();
                foreach (var item in hks)
                {
                    m.Remove(item);
                }

            }

        }
        public void DisplaySubjects(List<Subjects> m)
        {
            Console.WriteLine("Subjects List");
            foreach (var item in m)
            {
                Console.Write($"{item.SubName}  {item.SubCode}");
                Console.Write("\n");
            }

        }

    }
}
