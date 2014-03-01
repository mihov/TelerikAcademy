/**
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
 * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 * Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
 * female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different
 * kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ)
 */

namespace Animals
{
    using System;
    using System.Collections.Generic;

    class AnimalTestProgram
    {
        static void Main()
        {
            Dog testDog = new Dog("Sharo", 3, Animal.ESex.Male);
            Console.Write(testDog.Name + " >>> ");
            testDog.ProduceSound();

            Cat testCat = new Cat("Marciz", 4, Animal.ESex.Male);
            Console.Write(testCat.Name + " >>> ");
            testCat.ProduceSound();

            Frog testFrog = new Frog("Kikeritsa", 2);
            Console.Write(testFrog.Name + " >>> ");
            testFrog.ProduceSound();

            Kitten testKitten = new Kitten("Pouch", 1, Animal.ESex.Female);
            Console.Write(testKitten.Name + " >>> ");
            testKitten.ProduceSound();

            Tomcat testTomKat = new Tomcat("Pisso", 1, Animal.ESex.Male);
            Console.Write(testTomKat.Name + " >>> ");
            testTomKat.ProduceSound();

            // throw Exception "Kittens are Female only!"
            //Kitten testKittenMale = new Kitten("Pouch", 1, Animal.ESex.Male);


            List<Animal> animalList = new List<Animal>();


            animalList.Add(new Dog("Sharo", 2, Animal.ESex.Male));
            animalList.Add(new Cat("Marciz", 3, Animal.ESex.Male));
            animalList.Add(new Frog("Kikeritsa", 1));
            animalList.Add(new Kitten("Pouch", 1, Animal.ESex.Female));
            animalList.Add(new Tomcat("Pisso", 1, Animal.ESex.Male));
            animalList.Add(new Dog("Sharo", 20, Animal.ESex.Male));
            animalList.Add(new Cat("Marciz", 30, Animal.ESex.Male));
            animalList.Add(new Frog("Kikeritsa", 10));
            animalList.Add(new Kitten("Pouch", 1, Animal.ESex.Female));
            animalList.Add(new Tomcat("Pisso", 1, Animal.ESex.Male));
            animalList.Add(new Dog("Sharo", 12, Animal.ESex.Male));
            animalList.Add(new Cat("Marciz", 13, Animal.ESex.Male));
            animalList.Add(new Frog("Kikeritsa", 11));
            animalList.Add(new Kitten("Pouch", 1, Animal.ESex.Female));
            animalList.Add(new Tomcat("Pisso", 1, Animal.ESex.Male));

            int averageAge = Animal.AverageAge(animalList);
            Console.WriteLine("Average age is: {0}", averageAge);

        }
    }
}

/** Console output:
Sharo >>> BAU BAU
Marciz >>> Miauuuuuuu.
Kikeritsa >>> Kvack Kvack
Pouch >>> Miauuuuuuu.
Pisso >>> Miauuuuuuu.
The average age of all animals is: 7
Press any key to continue . . .
 
 */
