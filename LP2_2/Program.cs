using System;
  
namespace LP2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouAIEOU";
            string input_str;

            Console.WriteLine("Enter a Single Character");
            input_str = Console.ReadLine();         // Reads input string
            if (input_str.Length == 1)              // Check if string has single charecter only
            {
                Console.WriteLine("Given Character is  " + input_str);     // Prints the given character

                if (vowels.Contains(input_str))         // check if given charecter is present in "aeiouAEIOU" string
                    Console.WriteLine(" Entered Character is Vowel.");
                else 
                    Console.WriteLine(" Entered Charecter is not vowel.");
            }
            else Console.WriteLine("ERROR:Enter 1 charecter only.");
            Console.ReadKey();
        }
    }
}
