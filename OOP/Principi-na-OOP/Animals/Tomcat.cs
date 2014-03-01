namespace Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age, ESex sex)
            : base(name, age)
        {
            if (sex != ESex.Male)
            {
                throw new ArgumentException("Tomcats are Male only!");
            }
            this.Sex = sex;
        }
    }
}
