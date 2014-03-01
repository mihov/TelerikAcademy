namespace Animals
{
    using System;

    class Frog : Animal, ISound
    {
        public void ProduceSound()
        {
            Console.WriteLine("Kvack Kvack"); ;
        }

        public Frog(string name, int age)
            : base(name, age)
        { }

        public Frog(string name, int age, ESex sex)
            : base(name, age, sex)
        { }
    }
}
