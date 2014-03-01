namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public void ProduceSound()
        {
            Console.WriteLine("BAU BAU"); ;
        }

        public Dog(string name, int age)
            : base(name, age)
        { }

        public Dog(string name, int age, ESex sex)
            : base(name, age, sex)
        { }
    }
}
