using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Program to check whether a character is lower or upper case.\n");
            Console.Write("------------------------------------------------\n");
            Console.Write("Input a character: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("\nThe character is uppercase.\n");
            }
            else if(Char.IsLower(ch))
            {
                Console.WriteLine("\nThe character is lowercase.\n");
            }           
            else
            {   
                // User has entered a symbol or number etc. Example: 1,2, #, ?...
                Console.WriteLine("\nThe charecter is not an alphabet.\n");
            }
            Console.ReadKey();
        }
    }
}
