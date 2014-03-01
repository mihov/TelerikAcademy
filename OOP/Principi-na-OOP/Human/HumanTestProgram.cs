/**
 * Define abstract class Human with first name and last name. 
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
 * that returns money earned by hour by the worker. 
 * Define the proper constructors and properties for this hierarchy. 
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
 * Initialize a list of 10 workers and sort them by money per hour in descending order. 
 * Merge the lists and sort them by first name and last name.
 */

namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanTestProgram
    {
        static void Main()
        {
            Console.WriteLine("\n\n<<<<<STUDENT>>>>>>");
            List<Student> studentsList = new List<Student>();

            studentsList.Add(new Student("Ivan", "Ivanov", 4));
            studentsList.Add(new Student("Vasil", "Geogiev", 3));
            studentsList.Add(new Student("Georgi", "Angelov", 10));
            studentsList.Add(new Student("Stefan", "Peshev", 11));
            studentsList.Add(new Student("Plamen", "Ivanov", 1));
            studentsList.Add(new Student("Angel", "Charov", 8));
            studentsList.Add(new Student("Pesho", "Kirilov", 7));
            studentsList.Add(new Student("Kiril", "Ivanov", 5));
            studentsList.Add(new Student("Zahari", "Spasov", 9));
            studentsList.Add(new Student("Spas", "Ivanov", 2));

            var resultStudents = studentsList.OrderBy(X => X.Grade);

            Console.WriteLine(String.Join("\n", resultStudents));

            Console.WriteLine("\n\n<<<<<WORKER>>>>>>");
            List<Worker> workerList = new List<Worker>();

            workerList.Add(new Worker("Geogi", "Ivanov", 700, 8, 5));
            workerList.Add(new Worker("Vali", "Genov", 600, 8, 5));
            workerList.Add(new Worker("Geogi", "Peev", 500, 8, 5));
            workerList.Add(new Worker("Spas", "Kirilov", 400, 8, 5));
            workerList.Add(new Worker("Asen", "Ivanov", 300, 8, 5));
            workerList.Add(new Worker("Dani", "Kolev", 750, 8, 5));
            workerList.Add(new Worker("Zahari", "Vasilev", 650, 8, 5));
            workerList.Add(new Worker("Chavdar", "Bochev", 550, 8, 5));
            workerList.Add(new Worker("Dian", "Dochev", 330, 8, 5));
            workerList.Add(new Worker("Ivan", "Geov", 990, 8, 5));

            var resultWorker = workerList.OrderByDescending(y => y.MoneyPerHour());

            Console.WriteLine(String.Join("\n", resultWorker));

            Console.WriteLine("\n\n<<<<<MERGE>>>>>>");

            List<Human> humanTestList = new List<Human>();

            humanTestList.AddRange(resultStudents);
            humanTestList.AddRange(resultWorker);

            var resultMerged = humanTestList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            Console.WriteLine(String.Join("\n", resultMerged));
        }
    }
}
