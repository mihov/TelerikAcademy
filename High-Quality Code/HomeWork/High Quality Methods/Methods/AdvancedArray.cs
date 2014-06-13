namespace Methods
{
    using System;

    public class AdvancedArray
    {
        private const string NoElementsMSG = "There are no elements to look in.";

        private int[] elements;

        public AdvancedArray(params int[] integers)
        {
            if (integers == null || integers.Length == 0)
            {
                throw new ArgumentException(NoElementsMSG);
            }

            this.elements = new int[integers.Length];

            for (int i = 0; i < integers.Length; i++)
            {
                this.elements[i] = integers[i];
            }
        }

        public int MaxInteger
        {
            get
            {
                var maxElementIndex = 0;

                for (int i = 1; i < this.elements.Length; i++)
                {
                    if (this.elements[i] > this.elements[maxElementIndex])
                    {
                        maxElementIndex = i;
                    }
                }

                return this.elements[maxElementIndex];
            }
        }
    }
}