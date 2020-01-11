using System;

namespace Pro_C7
{
    public class CH3_P73_ObjectFunctionality
    {
        public static void Main(string[] args)
        {
            ObjectFunctionality();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            
            //A C# int is really shorthand for System.Int32,
            //which inherits the following members from System.Object

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();

        }
    }
}