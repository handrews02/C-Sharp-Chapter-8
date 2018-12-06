using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class CreateStudents
{
    static void Main()
    {
        Student first = new Student();
        Student second = new Student();
        first.IdNumber = 123;
        first.LastName = "Anderson";
        first.GradePointAverage = 3.5;
        second.IdNumber = 789;
        second.LastName = "Daniels";
        second.GradePointAverage = 4.1;

        Display(first);
        Display(second);

    }
    static void Display(Student stu)
    {
        WriteLine("{0,5} {1, -10} {2,6}", stu.IdNumber,
            stu.LastName, stu.GradePointAverage.ToString("F1"));
    
    }
}


    class Student
    {
        private int idNumber;
        private string lastname;
        private double gradepointAverage;
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public double GradePointAverage
        {
            get
            {
                return gradepointAverage;
            }
            set
            {
                if(value >= LOWEST_GPA && value <= HIGHEST_GPA)
                {
                    gradepointAverage = value;
                }
                else
                {
                    gradepointAverage = LOWEST_GPA;
                }
            }
        }

    }

