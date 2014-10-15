using System;
using System.Numerics;

class BitArray
{
    public const int BITS_COUNT = 100000;
    private BigInteger bitValues;

    // Indexer declaration
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < BITS_COUNT)
            {
                // Check the bit at position index
                if ((bitValues & (1 << index)) == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            else
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Index {0} is invalid!", index));
            }
        }

        set
        {
            if (index < 0 || index > BITS_COUNT - 1)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Index {0} is invalid!", index));
            }

            if (value < 0 || value > 1)
            {
                throw new ArgumentException(String.Format(
                    "Value {0} is invalid!", value));
            }

            // Clear the bit at position index
            bitValues &= ~((uint)(1 << index));

            // Set the bit at position index to value
            bitValues |= (uint)(value << index);
        }
    }

    public override string ToString()
    {
        BigInteger num = 0;
        for (int i = 0; i < 100000; i++)
        {
            if (this[i] == 1)
            {
                BigInteger pow = 1;

                for (int j = 0; j < i; j++)
                {
                    pow *= 2;
                }

                num += pow;
            }           
        }
            return num.ToString();
    }
}
