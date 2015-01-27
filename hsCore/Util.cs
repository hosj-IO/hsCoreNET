using System;
using System.IO;
using System.Linq;

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
    }
}
