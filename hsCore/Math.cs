using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsCore
{
    class Math
    {
        /// <summary>
        /// Random integer generator.
        /// </summary>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <returns>
        /// Random integer
        /// </returns>
        /// <exception cref="System.Exception">
        /// Parameters are not valid: Minimum is the same as the maximum.
        /// or
        /// Parameters are not valid: Minimum is greater the maximum.
        /// or
        /// Parameters are not valid.
        /// </exception>
        public static int RandomIntGenerator(int minimum, int maximum)
        {
            if (minimum < maximum)
            {
                Random random = new Random();
                return random.Next(minimum, maximum);
            }
            else if (minimum == maximum)
            {
                throw new ArgumentException("Parameters are not valid: Minimum is the same as the maximum.");
            }
            else if (minimum > maximum)
            {
                throw new ArgumentException("Parameters are not valid: Minimum is greater the maximum.");
            }
            throw new ArgumentException("Parameters are not valid.");
        }

        /// <summary>
        /// Determines whether the target integer is between the 2 parameters.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="includeEquals">if set to <c>true</c> target can also equal to max and minimum.</param>
        /// <returns>
        /// True if target is betweeen parameters
        /// </returns>
        public static bool IsIntegerBetween(int target, int minimum, int maximum, bool includeEquals)
        {
            if (target == null)
                throw new ArgumentException("Parameter " + "target" + " cannot be null");
            if (minimum == null)
                throw new ArgumentException("Parameter " + "minimum" + " cannot be null");
            if (maximum == null)
                throw new ArgumentException("Parameter " + "maximum" + " cannot be null");

            if (!includeEquals && target > minimum && target < maximum)
            {
                return true;
            }
            else if (includeEquals && target >= minimum && target <= maximum)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Randoms the double generator.
        /// </summary>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <returns>Random double</returns>
        /// <exception cref="System.Exception">
        /// Parameters are not valid: Minimum is the same as the maximum.
        /// or
        /// Parameters are not valid: Minimum is greater the maximum.
        /// or
        /// Parameters are not valid.
        /// </exception>
        public double RandomDoubleGenerator(double minimum, double maximum)
        {
            if (minimum < maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
            else if (minimum == maximum)
            {
                throw new ArgumentException("Parameters are not valid: Minimum is the same as the maximum.");
            }
            else if (minimum > maximum)
            {
                throw new ArgumentException("Parameters are not valid: Minimum is greater the maximum.");
            }
            throw new ArgumentException("Parameters are not valid.");
        }
    }
}
