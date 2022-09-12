using populate;

namespace PopulateandPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> m = new List<Students>();
            List<Teachers> m2 = new List<Teachers>();
            List<Subjects> m3 = new List<Subjects>();
            thime:
            Console.WriteLine("Enter option to choose\n 1.Students\n 2.Teachers\n 3.Subjects");
            int pi=Convert.ToInt32(Console.ReadLine());
            switch (pi) {
                case 1:
                   
                    int ji=Option();
                    if (ji == 1)
                    {
                    start:
                        Students s = new Students();
                        Console.WriteLine("Add Student");
                        string ko = Console.ReadLine();
                        s.Adding(ko, m);
                        s.DisplayStudents(m);
                        Console.WriteLine("Enter Yes to Continue to Add");
                        string du = Console.ReadLine();
                        if (du == "Yes")
                        {
                            goto start;
                        }
                        s.DisplayStudents(m);
                    }
                    else if (ji == 2)
                    {
                        if (m.Count > 0)
                        {
                            Students poo = new Students();
                            Console.WriteLine("Enter name to Remove students");
                            string po = Console.ReadLine();
                            poo.Removal(po, m);
                            poo.DisplayStudents(m);
                        }
                        else
                        {
                            Console.WriteLine("You have no students");
                        }
                    }
                    else if(ji == 3)
                    {
                        Students pot = new Students();
                        pot.DisplayStudents(m);
                    }
                    break;
                case 2:
                    int poi = Option();
                    if (poi == 1)
                    {
                    shock:
                        Teachers t = new Teachers();
                        Console.WriteLine("Add teacher");
                        string ok = Console.ReadLine();
                        t.Adding(ok, m2);
                        t.Displayteachers(m2);
                        Console.WriteLine("Enter Yes to Continue to Add");
                        string ud = Console.ReadLine();
                        if (ud == "Yes")
                        {
                            goto shock;
                        }
                        t.Displayteachers(m2);
                    }
                    else if (poi == 2)
                    {
                        if (m2.Count > 0)
                        {
                            Teachers ti = new Teachers();
                            Console.WriteLine("Enter name to Remove Teachers");
                            string pok = Console.ReadLine();
                            ti.Removal(pok, m2);
                            ti.Displayteachers(m2);
                           
                        }
                        else
                        {
                            Console.WriteLine("You have no teachers in the list");
                        }
                    }
                    else if(poi == 3)
                    {
                        Teachers toi = new Teachers();
                        toi.Displayteachers(m2);
                    }
                    break;
                case 3:
                    int hoi=Option();
                    if (hoi == 1)
                    {
                    dhre:
                        Subjects k = new Subjects();
                       
                        Console.WriteLine("Enter subjects to add");
                        string hot=Console.ReadLine();
                        k.Adding(hot, m3);
                        Console.WriteLine("Enter Yes to Continue");
                        string oko = Console.ReadLine();
                        if (oko == "Yes")
                        {
                            goto dhre;
                        }
                    }
                    
                    else if (hoi == 2)
                    {
                        if (m3.Count > 0)
                        {
                            Subjects toi=new Subjects();
                            Console.WriteLine("Enter Subject to Remove");
                            string hit = Console.ReadLine();
                            toi.Removal(hit, m3);

                        }
                        else
                        {
                            Console.WriteLine("Nothing in subject list");
                        }
                    }
                    else if(hoi == 3)
                    {
                        Subjects ty = new Subjects();
                        ty.DisplaySubjects(m3);
                    }
                    break;

            }
            Console.WriteLine("You want to go start of the program.Enter Yes");
            string pit = Console.ReadLine();
            if (pit == "Yes")
            {
                goto thime;

            }
            Console.ReadLine();
        }
        public static int Option()
        {
            Console.WriteLine("1.Add 2.Remove 3.Display");
            int jig = Convert.ToInt32(Console.ReadLine());
            return jig;
        }
        }
    }
