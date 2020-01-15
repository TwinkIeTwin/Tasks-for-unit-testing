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
        /// <exception cref="System.ArgumentException">Thrown when two parametres are 0 at the same time or one is 0 and another one is System.Int32.MinValue.
        /// </exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0)
            {
                return b != int.MinValue ? Math.Abs(b) :
                    throw new ArgumentException("can not return result because Abs(int.MinValue) is out of type int range", nameof(b));
            }

            if (b == 0)
            {
                return a != int.MinValue ? Math.Abs(a) :
                    throw new ArgumentException("can not return result because Abs(int.MinValue) is out of type int range", nameof(a));
            }

            uint absA = (uint)Math.Abs((long)a);
            uint absB = (uint)Math.Abs((long)b);
            uint dividend, devider;
            if (absA > absB)
            {
                dividend = absA;
                devider = absB;
            }
            else
            {
                dividend = absB;
                devider = absA;
            }

            uint remainder;

            while (true)
            {
                remainder = dividend - ((dividend / devider) * devider);
                if (remainder == 0)
                {
                    break;
                }

                dividend = devider;
                devider = remainder;
            }

            return (int)devider;
        }
    }
}