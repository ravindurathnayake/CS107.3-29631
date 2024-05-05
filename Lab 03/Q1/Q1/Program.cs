using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string CourseName
        {
            get { return courseName; }
        }

        public double Grade
        {
            get { return grade; }
        }

        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(instructorName);
            SetGrade(grade);
        }

        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrEmpty(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty.");
            }
            this.instructorName = instructorName;
        }

        public void SetGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }
            this.grade = grade;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Instructor Name: " + instructorName);
            Console.WriteLine("Letter Grade: " + CalculateLetterGrade());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Course course = new Course("OOP with C#", "Anton Jayakody", 85);
                course.PrintCourseInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
        }
    }
}