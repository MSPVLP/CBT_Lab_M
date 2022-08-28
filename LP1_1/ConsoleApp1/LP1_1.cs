using System;

namespace Lab_Practice_1_1
{
    internal class LP1_1
    {
        static void Main(string[] args)
        {
            string input_str;
            char input_char;

            Console.WriteLine("Enter a single charecter:");
            input_str = Console.ReadLine();         // Read String from user

            if (input_str.Length != 1)               // Check if exactly 1 char entered
            {
                Console.WriteLine("ERROR: Enter exactly 1 charecter only.");
            }
            else
            {
                input_char = char.Parse(input_str);     // Convert string to char
                
                Console.WriteLine("Given character is: " + input_char);
                
                if (Char.IsLower(input_char))
                    Console.WriteLine("The entered character is Lowercase.");
                
                else if (Char.IsUpper(input_char))
                    Console.WriteLine("The entered character is Uppercase.");
                
                else
                    Console.WriteLine("The entered character is not an alphabet.");
            }

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
