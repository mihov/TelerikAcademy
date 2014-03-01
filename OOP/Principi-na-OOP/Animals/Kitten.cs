namespace Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age, ESex sex)
            : base(name, age)
        {
            if (sex != ESex.Female)
            {
                throw new ArgumentException("Kittens are Female only!");
            }
            this.Sex = sex;
        }
    }
}
