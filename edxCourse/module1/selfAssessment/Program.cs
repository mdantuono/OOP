using System;

namespace SelfAssessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var UProgram1 = new UProgram("Information Technology");
            var Degree1 = new Degree("Bachelor's");
            var Degree2 = new Degree("Associate's");

            var Course1 = new Course("Daytime");
            var Course2 = new Course("Evening");

            var Teacher1 = new Teacher("Cliff");

            var Student1 = new Student("Mike", 4);
            var Student2 = new Student("Greg", 3);
            var Student3 = new Student("Sean", 4);

            int studentCount = Student.CountStudents();

            Console.WriteLine($"The program {UProgram1.Name} contains a {Degree1.Rank} and {Degree2.Rank} degree.");
            Console.WriteLine($"There is a {Course1.TimeOfDay} class and {Course2.TimeOfDay} class.");
            Console.WriteLine($"There are {studentCount} students in the course; {Student1.Name}, {Student2.Name}, and {Student3.Name}.");

        }
    }
}
