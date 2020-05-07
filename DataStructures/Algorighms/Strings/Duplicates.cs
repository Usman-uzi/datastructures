using System;
using System.Text;

namespace Strings
{
    public static class Duplicates
    {
        public static string RemoveDuplicateChars(string key)
        {
            var results = new StringBuilder(key.Length);
            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (results.ToString().IndexOf(value) == -1)
                {
                    results.Append(value);
                }
            }
            return results.ToString();
        }
    }
}
