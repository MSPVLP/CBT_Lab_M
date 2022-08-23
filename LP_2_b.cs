// Online C# Editor for free -https://www.programiz.com/csharp-programming/online-compiler/
// C# Program to Check whether given Character is Vowel or Not

using System;

public class Skill_Practice_2_b
{
    public static void Main()
    {
        char[] vowels = new char[] {'a','e','i','o','u'};
        
        char input_char;
        Console.WriteLine ("Enter a Single Character");
        input_char=char.Parse(Console.ReadLine());
        Console.WriteLine("Given Character is  " + input_char);
         
      
                // Condition for vowel checking
        if (vowels.Contains(input_char))
                Console.WriteLine(" Entered Character is Vowel");
        
         
    }
}
