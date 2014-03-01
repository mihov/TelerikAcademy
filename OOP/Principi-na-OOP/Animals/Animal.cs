namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Animal
    {
        public enum ESex
        {
            Unknown,
            Male,
            Female
        }

        private int age;
        private string name;
        private ESex sex;

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age can not be negative.");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty.");
                }
                this.name = value;
            }
        }

        public ESex Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
            }
        }

        public Animal(string name, int age)
            : this(name, age, ESex.Unknown)
        {
        }

        public Animal(string name, int age, ESex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public static int AverageAge(List<Animal> animalList)
        {
            int sum = 0;
            for (int i = 0; i < animalList.Count; i++)
            {
                sum += animalList[i].Age;
            }
            return sum / animalList.Count;
        }
    }
}
