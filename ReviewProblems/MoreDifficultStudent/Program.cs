using System;

namespace MoreDifficultStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(5, "Dillon", "Viera", 10000);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);
            
            //try
            //{
            //    myStudent.MakePayment(-500);
            //    Console.WriteLine(myStudent);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid");
            //    throw;
            //}

            Console.ReadKey();
        }
    }
}
