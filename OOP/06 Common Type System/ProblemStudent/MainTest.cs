/*
 * 01. Define a class Student, which contains data about a student – 
 * first, middle and last name, SSN, permanent address, mobile phone,
 * e-mail, course, specialty, university, faculty. 
 * Use an enumeration for the specialties, universities and faculties. 
 * Override the standard methods, inherited by  System.Object: Equals(), ToString(), 
 * GetHashCode() and operators == and !=.
 */

namespace ProblemStudent
{
    using System;
    using System.Collections.Generic;

    class MainTest
    {
        static void Main()
        {
            Student student1 = new Student("Angel", "Borisov", "Cvetkov", "Sofia, Malinov Bvd.", "08877665544",
                                           "a.cvetkov@telerik.com", 102030, 2, Specialty.ITSecurity,
                                           University.CityUniversity, Faculty.Informatics);

            Student student2 = (Student)student1.Clone();

            Student student3 = (Student)student1.Clone();

            student2.FistrName = "Pesho";
            student2.MiddleName = "Qatar";
            student2.LastName = "Vasilev";
            student2.SSN = 123456;
            student2.PermanentAddress = "Varna, Bulgaria Bvd.";
            student2.Email = "p.vasilev@ibm.com";
            student2.Course = 4;
            student2.Specialty = Specialty.OrganizationGrowth;
            student2.University = University.KingsCollegeLondon;
            student2.Faculty = Faculty.History;



            Console.WriteLine("Student 1:");
            Console.WriteLine(student1);

            Console.WriteLine("\n\nStudent 2:");
            Console.WriteLine(student2);

            Console.WriteLine("\n\nCompare students:");
            Console.WriteLine("{0} == {1} ==> {2}", "student1", "student2", student1 == student2);
            Console.WriteLine("{0} != {1} ==> {2}", "student2", "student3", student2 != student3);
            Console.WriteLine("{0}.Equals({1}) ==> {2}", "student3", "student1", student3.Equals(student1));

            Console.WriteLine("\n\nstudent1.GetHashCode() ==> {0}", student1.GetHashCode());

            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);

            Console.WriteLine("\n\nPrint Unsorted list.");
            Console.WriteLine(String.Join("\n===============\n", listOfStudents));

            listOfStudents.Sort();
            Console.WriteLine("\n\nPrint Sorted list.");
            Console.WriteLine(String.Join("\n===============\n", listOfStudents));

            Person person1 = new Person("Goro");
            Person person2 = new Person("Pesho", 25);

            Console.WriteLine("\n\n<<<<<<<<< Class Person Tests >>>>>>>>>");
            Console.WriteLine(person1);
            Console.WriteLine(person2);

        }
    }
}

/* 
 * Console output:
Student 1:
SSN: 102030
N: Angel Borisov Cvetkov
A: Sofia, Malinov Bvd.
P: 08877665544
@: a.cvetkov@telerik.com
C: 2
S: ITSecurity
U: CityUniversity
F: Informatics



Student 2:
SSN: 123456
N: Pesho Qatar Vasilev
A: Varna, Bulgaria Bvd.
P: 08877665544
@: p.vasilev@ibm.com
C: 4
S: OrganizationGrowth
U: KingsCollegeLondon
F: History



Compare students:
student1 == student2 ==> False
student2 != student3 ==> True
student3.Equals(student1) ==> True


student1.GetHashCode() ==> 276964698


Print Unsorted list.
SSN: 102030
N: Angel Borisov Cvetkov
A: Sofia, Malinov Bvd.
P: 08877665544
@: a.cvetkov@telerik.com
C: 2
S: ITSecurity
U: CityUniversity
F: Informatics

===============
SSN: 123456
N: Pesho Qatar Vasilev
A: Varna, Bulgaria Bvd.
P: 08877665544
@: p.vasilev@ibm.com
C: 4
S: OrganizationGrowth
U: KingsCollegeLondon
F: History

===============
SSN: 102030
N: Angel Borisov Cvetkov
A: Sofia, Malinov Bvd.
P: 08877665544
@: a.cvetkov@telerik.com
C: 2
S: ITSecurity
U: CityUniversity
F: Informatics



Print Sorted list.
SSN: 102030
N: Angel Borisov Cvetkov
A: Sofia, Malinov Bvd.
P: 08877665544
@: a.cvetkov@telerik.com
C: 2
S: ITSecurity
U: CityUniversity
F: Informatics

===============
SSN: 102030
N: Angel Borisov Cvetkov
A: Sofia, Malinov Bvd.
P: 08877665544
@: a.cvetkov@telerik.com
C: 2
S: ITSecurity
U: CityUniversity
F: Informatics

===============
SSN: 123456
N: Pesho Qatar Vasilev
A: Varna, Bulgaria Bvd.
P: 08877665544
@: p.vasilev@ibm.com
C: 4
S: OrganizationGrowth
U: KingsCollegeLondon
F: History



<<<<<<<<< Class Person Tests >>>>>>>>>
Name: Goro
Age : Unknown

Name: Pesho
Age : 25

Press any key to continue . . .
 
 */
