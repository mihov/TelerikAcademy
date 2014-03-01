namespace ProblemBitArray64
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number = 0)
        {
            this.number = number;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.GetBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int this[int index]
        {
            get
            {
                if (!this.CheckIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                int[] bits = this.GetBits();
                return bits[63 - index];
            }
        }

        public static bool operator ==(BitArray64 arrayOne, BitArray64 arrayTwo)
        {
            return arrayOne.Equals(arrayTwo);
        }

        public static bool operator !=(BitArray64 arrayOne, BitArray64 arrayTwo)
        {
            return !arrayOne.Equals(arrayTwo);
        }

        public override bool Equals(object obj)
        {
            BitArray64 equalTo = obj as BitArray64;

            return this.number.Equals(equalTo.number);
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public override string ToString()
        {
            return String.Join("", this);
        }

        private bool CheckIndex(int index)
        {
            if (index < 0 || index > 63)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private int[] GetBits()
        {
            ulong number = this.number;

            int[] bits = new int[64];

            int counter = 63;

            while (number > 0)
            {
                bits[counter] = (int)number % 2;
                number = number / 2;
                counter--;
            }

            do
            {
                bits[counter] = 0;
                counter--;
            } while (counter >= 0);

            return bits;
        }
    }
}
