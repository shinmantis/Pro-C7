using System;

namespace Pro_C7
{
    public class CH3_P71_NewingDataTypes
    {
        //Rename to Main to use
        public static void Main1(string[] args)
        {
            //Using to "new" to create new variables.  For intrinsic data types this will assign a default value
            
            Console.WriteLine("=> Using new to create variables: ");
            bool b = new bool(); //defaults to true
            int i = new int(); //defaults to 0
            double d = new double(); //defaults to 0
            DateTime dt = new DateTime(); //defaults to 1/1/0001 00:00:00 A.M
            
            //{x} always follows sequential ordering regardless of "actual order"
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        
    }
}