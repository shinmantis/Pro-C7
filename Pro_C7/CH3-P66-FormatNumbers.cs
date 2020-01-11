using System;

namespace Pro_C7
{
    public class CH3_P66_FormatNumbers
    {
        //Rename to Main to use
        public static void Main1 (String[] args)
        {
            
            FormatNumericalData();

        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value of 99999 in various formats is as follows...");
            Console.WriteLine("c (Currency) format:{0:c}", 99999);
            Console.WriteLine("d (Decimal) format:{0:d9}", 99999);
            Console.WriteLine("f3 (Fixed Point) format:{0:f3}", 99999);
            Console.WriteLine("n (Basic Numerical With Commas) format:{0:n}", 99999);
            Console.WriteLine("x (Hexadecimal) format: {0:x}", 99999);
            Console.WriteLine("E (Exponential Notation) format: {0:e}", 99999);
        }
        
        
        
    }
}