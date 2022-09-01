using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nCheck whether a character is lower case or upper case :\n");
            Console.Write("------------------------------------------------------------\n");
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
