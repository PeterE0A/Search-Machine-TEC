using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Search_Machine_TEC
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            int i = 2;

            while (i == 2)
            {




                Console.WriteLine("Type 1 for Teachers, 2 for Students, or 3 for Subjects:");
                Console.WriteLine("");
                foreach (string s in Enum.GetNames(typeof(ThreeOptions)))
                    Console.WriteLine(s);
                Console.WriteLine("");
                int choose = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (choose == 1)
                {
                start:

                    Console.WriteLine("Type 1 for Jens, 2 for John, or 3 for Lars:");
                    Console.WriteLine("");
                    foreach (string n in Enum.GetNames(typeof(Teachersnames)))
                        Console.WriteLine(n);
                    Console.WriteLine("");
                    int chooseTeacher = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (chooseTeacher == 1)
                    {
                        Console.WriteLine("Jens:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.Science);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Joe + ", " + Student.Mike);
                        Console.ReadLine();
                    }

                    else if (chooseTeacher == 2)
                    {
                        Console.WriteLine("John:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.Math);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Larry);
                        Console.ReadLine();
                    }
                    else if (chooseTeacher == 3)
                    {
                        Console.WriteLine("Lars:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.English);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Larry + ", " + Student.Joe);
                        Console.ReadLine();
                    }
                    else
                    {


                        goto start;

                    }


                }

                if (choose == 2)
                {

                start:

                    Console.WriteLine("Type 1 for Larry, 2 for Mike, or 3 for Joe:");
                    Console.WriteLine("");
                    foreach (string y in Enum.GetNames(typeof(Student)))
                    Console.WriteLine(y);
                    Console.WriteLine("");
                    int chooseStudent = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (chooseStudent == 1)
                    {
                        Console.WriteLine("Larry:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.Math);
                        Console.WriteLine("");
                        Console.WriteLine("Teachers:" + Teachersnames.John);
                        Console.ReadLine();
                    }

                    else if (chooseStudent == 2)
                    {
                        Console.WriteLine("Mike:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.Science + ", " + Subject.English);
                        Console.WriteLine("");
                        Console.WriteLine("teachers:" + Teachersnames.Jens + ", " + Teachersnames.Lars);
                        Console.ReadLine();

                    }
                    else if (chooseStudent == 3)
                    {
                        Console.WriteLine("Joe:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("subjects:" + Subject.English);
                        Console.WriteLine("");
                        Console.WriteLine("teachers:" + Teachersnames.Lars);
                        Console.ReadLine();
                    }
                    else
                    {


                        goto start;

                    }



                }


                if (choose == 3)
                {

                start:

                    Console.WriteLine("Type 1 for Math, 2 for English, or 3 for Science:");
                    Console.WriteLine("");
                    foreach (string x in Enum.GetNames(typeof(Subject)))
                        Console.WriteLine(x);
                    Console.WriteLine("");
                    int chooseSubject = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (chooseSubject == 1)
                    {
                        Console.WriteLine("Math:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("teachers:" + Teachersnames.John);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Mike + ", " + Student.Joe);
                        Console.ReadLine();
                    }

                    else if (chooseSubject == 2)
                    {
                        Console.WriteLine("English:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("teachers:" + Teachersnames.Lars);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Mike + ", " + Student.Larry);
                        Console.ReadLine();

                    }
                    else if (chooseSubject == 3)
                    {
                        Console.WriteLine("Science:");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("teachers:" + Teachersnames.Jens);
                        Console.WriteLine("");
                        Console.WriteLine("students:" + Student.Joe);
                        Console.ReadLine();
                    }

                    else
                    {


                        goto start;

                    }


                }
                Console.Clear();

                Console.ReadKey();
            }
        }
    }
}
