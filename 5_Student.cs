using System;
//create a class student with roll no,name and percentage.initialise the data member using constructor.
//while display student details if percentage is less than 40 show fail else show pass.
//student roll no should be auto generated.
namespace TSystem_Inheritance
{
    public class Student
    {
        static int count;
        protected int sroll;
        protected String sname;
        double spercentage;
        public Student()
        {
            sname = "";
            spercentage = 0.0d;
        }
        public Student(string sname,double spercentage)
        {
            count++;
            sroll =count;
            this.sname = sname;
            this.spercentage = spercentage;

        }
        public void calculatePercentage()
        {
            if(spercentage<40)
            {
                Console.WriteLine("fail");
            }
            else
            {
                Console.WriteLine("pass");
            }
        }
        public static int getCount()
        {
            return count;
        }
        public override string ToString()
        {
            return "student roll number is " + sroll + "\nstudent name is " + sname + "\nstudent percentage is " + spercentage;
        }


    }
}
