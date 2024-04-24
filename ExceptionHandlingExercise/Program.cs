using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // A char[] arr, contain 6 numbers and 3 letters 
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            // A list called numbers that will hold integers
            List<int> numbers = new List<int>();

            // A string variable with an empty string initializer
            string str = "";

            // A foreach loop to iterate through character array
            foreach (var character in arr)
            {
                // A try-catch inside foreach loop
                try
                {
                    // To set string variable to each array element in char[] to .ToString()
                    str = character.ToString();

                    // Parse your string variable and store in an int variable
                    int num = int.Parse(str);

                    // Add each int to the list
                    numbers.Add(num);
                }
                catch (FormatException)
                {                 
                    Console.WriteLine($"Unable to Parse '{character}'"); // character will be the name of each item in your collection
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
