using System;
using System.Collections.Generic;
using System.Text;

namespace MoreDifficultStudent
{
    class Student
    {
        // hold alt+shift, use arrow keys to select lines
        // let go of alt + shift and type

        public int SoonerId { get; set; }
        public string FirstName    {get; set;}
        public string LastName     {get; set;}
        public bool IsOnProbation  {get; set;}
        public double GPA          {get; set;}
        private double BursarBalance;


        /// <summary>
        /// default constructor for student 
        /// </summary>
        public Student()
        {
            SoonerId = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;
        }

        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerId = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;

            }
            else
            {
                throw new Exception("INVALID PAYMENT AMOUNT");
            }
        }
        public double CheckBalance()
        {
            return BursarBalance;
        }
        public override string ToString()
        {
            string result = $"{FirstName} {LastName} {SoonerId} has a {GPA.ToString("N2")} GPA and owes {BursarBalance}";
            
            if(IsOnProbation ==true)
            {
                result += "\nIS on Probation";
            }
            else
            {
                result += "\nIs not on Probation";
            }
            return result;  
        }
    }
}
