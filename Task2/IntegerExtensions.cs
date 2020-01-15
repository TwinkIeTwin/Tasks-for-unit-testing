using System;

namespace Task2
{
    /// <summary>
    /// class for getting extension methods for int.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Greatest common divisor of two input numbers.
        /// </summary>
        /// <param name="a"> first number. </param>
        /// <param name="b"> second number. </param>
        /// <returns>Greatest coomon divisor. </returns>
        /// <example>
        /// <code>
        /// int c = IntegerExtensions.GetGcd(4, 5);
        /// if (c > 1)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentException">Thrown when two parametres are 0 at the same time.
        /// </exception>
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