using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("");
            List<Student> students = new List<Student>();

            Student stud1 = new Student();
            Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            stud1.name = "Billy";
            stud1.id = 2;
            students.Add(stud1);

            Student stud2 = new Student("Dillon", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }

            DateTime current = DateTime.Now;
            DateTime past = Convert.ToDateTime("1/1/2020");

            var result = current - past;

            Console.WriteLine($"Has been {result.Days} days since the new year, which was on a {past.DayOfWeek}");
            TimeSpan difference = current - stud1.enrollDate;
            Console.WriteLine($"It has been {difference.TotalMilliseconds} milliseconds since {stud1.name} has enrolled");

            Console.WriteLine($"there are currently {Student.totalStudents} enrolled");


            //Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            //Console.WriteLine($"{stud2.name} has an id of {stud2.id}");

            Console.ReadKey();
        }
    }
}
