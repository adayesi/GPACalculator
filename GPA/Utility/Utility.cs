using System;
using System.Collections.Generic;
using System.Text;

namespace GPA.Utility
{
    public static class Utility
    {
        public static bool StringValidator(string value)
        {
            bool isValid=false;
            if (value!="" && value.Length>=6)
            {
                isValid = true;
            }
            else
            {

                isValid = false;
                Console.WriteLine("---- please enter your course code----");
            }
            return isValid;
        }
    }
}
