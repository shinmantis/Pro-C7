using System;

namespace Pro_C7
{
    public class CH3_P73_DataTypeFunctionality
    {
        //Rename to Main to use
        public static void Main1(string[] args)
        {
            DataTypeFunctionality();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data Type Functionality:");

            Console.WriteLine("Max of int = {0}", int.MaxValue);
            Console.WriteLine("Min of int = {0}", int.MinValue);
            Console.WriteLine("Max of Double = {0}", double.MaxValue);
            Console.WriteLine("Min of Double = {0}", double.MinValue);
            Console.WriteLine("double.Epsilon = {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity = {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfitity = {0}", double.NegativeInfinity);
            Console.WriteLine();
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

        }
    }
}