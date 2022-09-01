using System;
  
namespace LP2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Alphabet");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is Not Vowel");
                    break;
            }
            Console.ReadKey();
        }
    }
}
