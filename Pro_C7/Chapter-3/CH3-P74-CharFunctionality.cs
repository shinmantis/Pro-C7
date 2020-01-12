using System;

namespace Pro_C7
{
    public class CH3_P74_CharFunctionality
    {
        //Rename to Main to use
        public static void Main(string[] args)
        {
            CharFunctionality();


        }

        public static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality");

            char myChar = 'a';
            
            Console.WriteLine("char.isDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.isLetter('a'): {0}", char.IsLetter(myChar));
            
            //Note indices are zero based.
            Console.WriteLine("char.isWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.isWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();

        }
        
    }
}