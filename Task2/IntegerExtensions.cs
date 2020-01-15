using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }
            else if (a == 0)
            {
                return Math.Abs(b);
            }
            else if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                // use long because of potential overflow when a or b is max negative int
                long absA = Math.Abs((long)a);
                long absB = Math.Abs((long)b);
                long k1, k2;
                if (absA > absB)
                {
                    k1 = absA;
                    k2 = absB;
                }
                else
                {
                    k1 = absB;
                    k2 = absA;
                }

                long remainder;

                // euclidean algorithm
                while (true)
                {
                    remainder = k1 - ((k1 / k2) * k2);
                    if (remainder == 0)
                    {
                        break;
                    }

                    k1 = k2;
                    k2 = remainder;
                }

                return (int)k2;
            }
        }
    }
}