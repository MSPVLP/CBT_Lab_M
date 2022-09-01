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
            // Call of Function
            string char_to_check = get_one_char();
            //Print given caharacter
            Console.WriteLine(char_to_check);
            // Checks if character is in string 
            if (vowels.Contains(char_to_check))             
                Console.WriteLine("Given Character is Vowel");
            else            
                Console.WriteLine("Given Character is Not Vowel");

            Console.ReadKey();
        }
        static string get_one_char()  // Function definition
        {
            string inp_str = Console.ReadLine();
            char c = inp_str[0];
            return (inp_str);
        }
    }
}