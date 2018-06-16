using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment_1
{
    class Student
    {
        public string Name { get; set; }
        public int Year { get; set; }

        private static int students = 0;
        public Student(string name, int year)
        {
            this.Name = name;
            this.Year = year;
            students++;
        }

        public static int CountStudents()
        {
            return students;
        }
    }
}
