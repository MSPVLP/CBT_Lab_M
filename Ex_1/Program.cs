using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Program to check whether a character is lower or upper case.\n");
            Console.Write("------------------------------------------------\n");
            
            bool quit = false;
            string input_str;
            char ch;

            while (!quit) {

                Console.Write("Enter a character [Enter . to quit]: ");
                input_str = Console.ReadLine();

                if (input_str.Length != 1)               // Check if exactly 1 char entered
                {
                    Console.WriteLine("ERROR: Enter exactly 1 charecter only.");
                    continue;
                }
                
                ch = Char.Parse(input_str);

                if (ch == '.')
                {
                    quit = true;
                    break;
                }

                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.\n");
                }
                else if (Char.IsLower(ch))
                {
                    Console.WriteLine("\nThe character is lowercase.\n");
                }
                else
                {
                    // User has entered a symbol or number etc. Example: 1,2, #, ?...
                    Console.WriteLine("\nThe charecter is not an alphabet.\n");
                }

                // Check if user chose to quit


            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
