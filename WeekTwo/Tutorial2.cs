using System;
using System.Collections.Generic;

namespace tutorialTwo
{
    class Tutorial2
    {
        static void Main(string[] args)
        {
            Tutorial2 t2 = new Tutorial2();

            List<int> CoursePartaking = new List<int>();


            //Ask for students info - EXTRA

            Console.WriteLine("What is your first name");
            String firstName = Console.ReadLine();

            Console.Write("What is your Last Name\n");
            String lastName = Console.ReadLine();

            Console.Write("Answer the following questions with Y for YES or N for NO\n");


            Console.Write("Are you doing course 203?\n");
            String course203 = Console.ReadLine();

            if (course203 == "Y" || course203 == "y")
            {
                CoursePartaking.Add(203);
            }

            Console.Write("Are you doing course 202?\n");
            String course202 = Console.ReadLine();

            if (course202 == "Y" || course202 == "y")
            {
                CoursePartaking.Add(202);
            }

            Console.Write("Are you doing course 101?\n");
            String course101 = Console.ReadLine();

            if (course101 == "Y" || course101 == "y")
            {
                CoursePartaking.Add(101);
            }



            Student student = new Student();
            student.Name = firstName;
            student.LastName = lastName;
            student.CourseCodes = CoursePartaking;
            t2.OutputInformation(student);

            Professor prof = new Professor();
            prof.Name = "Reinhardt";
            prof.LastName = "Botha";
            prof.TeachesSubjects = new List<string> {"Mobile Development", "Cryptography" };
            t2.OutputInformation(prof);

        }

        public void OutputInformation(object person)
        {
            switch (person)
            {
                case Student student:
                    Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses { String.Join<int>(", ", student.CourseCodes)}");
                    break;

                case Professor prof:
                    Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches { String.Join<string>(",", prof.TeachesSubjects)}");
                    break;

                case null:
                    Console.WriteLine($"Object {nameof(person)} is null");
                    break;

                default:
                    Console.WriteLine("Unknown object detected");
                    break;
            }
        }
    }
}
