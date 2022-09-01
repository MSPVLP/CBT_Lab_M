using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Check whether a character is lower or upper case\n");
            Console.Write("------------------------------------------------\n");
            Console.Write("Input a character: ");
            char ch = (char)Console.Read();
              if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.\n");
                }
                else
                {
                    Console.WriteLine("\nThe character is lowercase.\n");
                }           
            Console.ReadKey();
        }
    }
}
