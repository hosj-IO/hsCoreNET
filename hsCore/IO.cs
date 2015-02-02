using System;
using System.IO;
using System.Linq;

namespace hsCore
{
    public class IO
    {
        /// <summary>
        /// Determines whether the suspected childPath is family of the parentPath
        /// </summary>
        /// <param name="childPath">The child path.</param>
        /// <param name="parentPath">The parent path.</param>
        /// <returns>True when child is subfolder of Parent</returns>
        public static bool IsChildOfParent(string childPath, string parentPath)
        {
            if (string.IsNullOrWhiteSpace(childPath))
                throw new ArgumentException("Child path cannot be null or only be whitespaces");
            if (string.IsNullOrWhiteSpace(parentPath))
                throw new ArgumentException("Parent path cannot be null or only be whitespaces");

            string childPathFull = Path.GetFullPath(childPath).ToUpperInvariant();
            string parentPathFull = Path.GetFullPath(parentPath).ToUpperInvariant();

            if (childPathFull.StartsWith(parentPathFull))
                return true;
            return false;
        }

        /// <summary>
        /// Determines whether the directory is empty.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>True when directory is empty.</returns>
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}
