using System;
  
namespace LP2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char input_char;
            Console.WriteLine("Enter a Single Character");
            input_char = char.Parse(Console.ReadLine());                // Reads a Character 
            Console.WriteLine("Given Character is  " + input_char);     // Prints the given character
            
            // Condition for vowel checking
            if (vowels.Contains(input_char))
                Console.WriteLine(" Entered Character is Vowel");
        }
    }
}
