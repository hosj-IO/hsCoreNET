using System;
using System.Globalization;
namespace hsCore
{
    public class Util
    {
        /// <summary>
        /// Softs to string. Does not throw error when the parameter is null.
        /// </summary>
        /// <param name="convertingObject">The converting object.</param>
        /// <returns>toString of Object or empty.</returns>
        public static string SoftToString(object convertingObject)
        {
            if (convertingObject != null)
                return convertingObject.ToString();
            return "";
        }

        /// <summary>
        /// Converts a string to double, while parsing a comma to dot.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Parse to double is not possible, check the arguments</exception>
        public static double ConvertToDoubleInvariantDotComma(string input)
        {
            double output;
            input = input.Replace(',', '.');
            if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out output))
                throw new ArgumentException("Parse to double is not possible, check the arguments");
            return output;
        }
    }
}
