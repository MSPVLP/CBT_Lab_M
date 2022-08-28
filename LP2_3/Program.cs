using System;
 
namespace LP2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string vowels = "aeiouAEIOU";
            // get char input from user
            Console.WriteLine("Enter One Character");
            string char_to_check = get_one_char();          // Call of Function            
            Console.WriteLine(char_to_check);               //Print given caharacter

            if (vowels.Contains(char_to_check))             // Checks if character is in string 
                Console.WriteLine("Given Character is Vowel");
            else            
                Console.WriteLine("Given Character is Not Vowel");

            Console.ReadKey();
        }
        static string get_one_char()                        // Function definition
        {
            string inp_str = Console.ReadLine();
            char c = inp_str[0];
            return (inp_str);
        }
    }
}
