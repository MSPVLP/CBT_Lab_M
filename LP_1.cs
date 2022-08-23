// Online C# Editor for free - https://www.programiz.com/csharp-programming/online-compiler/
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Skill_Practice_1_a
{
    public static void Main()
    {
        char input_char;
        Console.WriteLine ("Enter a Single Character");
        input_char=char.Parse(Console.ReadLine());
       Console.WriteLine("Given Character is  " + input_char);
        
         if(Char.IsLower(input_char))
            Console.WriteLine("The Entered Character is Lowercase");
         else if(Char.IsUpper(input_char))
                   Console.WriteLine("The Entered Character is Uppercase");
              else
                  Console.WriteLine("The Entered Character is Not Alphabets");
    }
}
