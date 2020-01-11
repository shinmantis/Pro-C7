using System;
using System.Windows.Input;

namespace Pro_C7
{
    public class CH3_P70_DisplayMessage
    {
        //Rename to Main to use
        public static void Main(String[] args)
        {
            DisplayMessage();

        }


        static void DisplayMessage()
        {
            // Using string.Format() to format a string literal.
            string userMessage = string.Format("10000 in hex is {0:x}", 1000);

            //System.Windows.MessageBox.show(userMessage);

        }
    }
}