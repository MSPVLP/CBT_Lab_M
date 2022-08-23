// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


using System;
public class Program
{
    static void Main()
    {
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u' };
        // get char input from user
        Console.WriteLine("Enter One Character");
        char char_to_check = get_one_char();
        //print given caharacter
        Console.WriteLine(char_to_check);
        
        if(vowels.Contains(char_to_check))
        {
            Console.WriteLine("Given Character is Vowel");
        }
        else
        {
            Console.WriteLine("Given Character is Not Vowel");
        }
    }

    static char get_one_char()
    {
        string inp_str = Console.ReadLine();
        char c = inp_str[0];
        return (c);
    }
}
