namespace Methods
{
    using System;
    public class TasksTester
    {
        static void Main()
        {

            // 01. Test - Triangle
            Triangle triangleForTest = new Triangle(3, 4, 5);
            Console.WriteLine(triangleForTest.Area);

            // 02. Test - NumberToDigit
            Console.WriteLine(Translator.NumberToDigit(5));

            // 03. Test - FindMax
            AdvancedArray arrayForTest = new AdvancedArray(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(arrayForTest.MaxInteger);

            // 04. Test - PrintAs
            NumberPrint.PrintAsDecimal(1.3);
            NumberPrint.PrintAsPercent(0.75);
            NumberPrint.PrintIdented(2.30);

            // 05. Test - Distance
            Distance testDistance = new Distance(3, -1, 3, 2.5);
            Console.WriteLine(testDistance.Value);
            Console.WriteLine("Horizontal? " + testDistance.IsHorizontal);
            Console.WriteLine("Vertical? " + testDistance.IsVertical);

            // 06. Test - Student
            Student peter = new Student("Peter", "Ivanov", "17.03.1992", "From Sofia");
            Student stella = new Student("Stella", "Markova", "03.11.1993", "From Vidin, gamer, high results");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
