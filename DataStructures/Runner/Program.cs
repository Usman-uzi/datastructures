using Strings;
using System;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result =Duplicates.RemoveDuplicateChars("UsmanRafiq");
            Console.WriteLine(result);

            _ = Console.ReadKey();
        }
    }
}
