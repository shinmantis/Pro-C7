using System;

namespace Pro_C7
{
    public class CH3DefaultLiteral
    {

        //Rename to Main to use
        public static void Main1(string[] args)
        {
            DefaultDeclarations();
        }


        private static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations: ");
            int myInt = default; //Assigns default value so you don't need to guess.
        }
        
    }
}