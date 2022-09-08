using System;

namespace LP1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nProgram to Check whether a character is lower case or upper case :\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Input a Single character : ");
            char ch = (char)Console.Read();
            // Call of Function
            checkCase(ch);
            Console.ReadKey();
        }
        //Function Definition
        static void checkCase(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
                Console.WriteLine("\n" + ch +
                        " is an UpperCase character");
            else if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("\n" + ch +
                        " is an LowerCase character");
        }
    }
}
