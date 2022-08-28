﻿using System;
namespace LP2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_str;
            char input_char;
            Console.WriteLine("Enter a Single Character");          
            input_str = (Console.ReadLine());        // Reads an input from user

            if (input_str.Length != 1)              // Checks if user entered input is 1 character
                Console.WriteLine("Given Input is  " + input_str);
            else
            {
                input_char = char.Parse(input_str);        // Converts string to a Single Character
                Console.WriteLine("Given Character is  " + input_char);
                // Condition for vowel checking
                if (input_char == 'a' || input_char == 'e' || input_char == 'i' || input_char == 'o' || input_char == 'u' 
                     || input_char == 'A' || input_char == 'E' || input_char == 'I' || input_char == 'O' || input_char == 'U')
                    Console.WriteLine("Entered Character '" + input_char + "' is Vowel.");
                else
                    Console.WriteLine("Entered Character '" + input_char + "' is Not a Vowel.");
            }
            Console.ReadKey();
        }
    }
}
