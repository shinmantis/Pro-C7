using System;

namespace Pro_C7
{
    public class CH3_P64_GetUserData
    {
        //Rename to Main to use
        static void Main1(string[] args)
        {
            Console.WriteLine("*****Basic Console I/0");
            GetUserData();
            Console.ReadLine();
        }


        private static void GetUserData()
        {
            //Get name and age
            Console.WriteLine("Please Enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string userAge = Console.ReadLine();
            
            //Change echo color for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            //Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} year(s) old.", userName, userAge);
            
            //Restore previous color
            Console.ForegroundColor = prevColor;

        }
    }
}