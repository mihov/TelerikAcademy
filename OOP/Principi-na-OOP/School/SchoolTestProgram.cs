/**
 * We are given a school. In the school there are classes of students. 
 * Each class has a set of teachers. Each teacher teaches a set of disciplines. 
 * Students have name and unique class number. Classes have unique text identifier. 
 * Teachers have name. Disciplines have name, number of lectures and number of exercises. 
 * Both teachers and students are people. 
 * Students, classes, teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of  OOP) and their attributes and operations, 
 * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 */

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolTestProgram
    {
        static void Main()
        {
            Student testStudent1 = new Student("Ivan", "Coomentssssss", "STD0001");
            Student testStudent2 = new Student("Petar", "Petar is good student", "STD0002");
            Student testStudent3 = new Student("Gosho", "Gosho momche losho", "STD0003");
            Student testStudent4 = new Student("Stefan", "No Comments", "STD0001");
            Student testStudent5 = new Student("Spas", "Good for dance", "STD0002");
            Student testStudent6 = new Student("Tsetso", "Big head", "STD0003");


            Console.WriteLine(testStudent1);

            Discipline testDiscipline1 = new Discipline("OOP", 12, 5);
            Discipline testDiscipline2 = new Discipline("HTML", 10, 4);
            Discipline testDiscipline3 = new Discipline("Java", 20, 15);
            Discipline testDiscipline4 = new Discipline("PHP", 17, 10);
            testDiscipline1.Comments = "New comments added.";

            Console.WriteLine(testDiscipline1);

            Teacher testTeacher1 = new Teacher("Preslav");
            Teacher testTeacher2 = new Teacher("Boris");
            Teacher testTeacher3 = new Teacher("Kiril");
            Console.WriteLine(testTeacher1);

            testTeacher1.AddDiscipline(testDiscipline1);
            testTeacher1.AddDiscipline(testDiscipline2);

            testTeacher2.AddDiscipline(testDiscipline2);
            testTeacher2.AddDiscipline(testDiscipline3);

            testTeacher3.AddDiscipline(testDiscipline4);
            Console.WriteLine(testTeacher1);

            Class testClass1 = new Class("CLS001");
            testClass1.AddStudent(testStudent1);
            testClass1.AddStudent(testStudent2);
            testClass1.AddStudent(testStudent3);
            testClass1.AddStudent(testStudent6);

            testClass1.AddTeacher(testTeacher2);
            testClass1.AddTeacher(testTeacher1);

            Console.WriteLine("\n\n<<<<<< Final Test >>>>>>>>>\n");
            Console.WriteLine(testClass1);
            Console.WriteLine("\n<<<<<< END of final Test >>>>>>>>>");







        }
    }
}
