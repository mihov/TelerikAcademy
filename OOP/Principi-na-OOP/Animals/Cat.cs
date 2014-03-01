namespace Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        public void ProduceSound()
        {
            Console.WriteLine("Miauuuuuuu."); ;
        }

        public Cat(string name, int age)
            : base(name, age)
        { }

        public Cat(string name, int age, ESex sex)
            : base(name, age, sex)
        { }
    }
}
