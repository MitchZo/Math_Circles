using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Validator
    {
        //fields
        private bool isValid;

        //property
        public bool IsValid
        {
            get
            {
                return isValid;
            }
            set
            {
                isValid = value;
            }
        }
        
        //constructor
        public Validator()
        {

        }

        //methods
        public static bool Double(string input)
        {
            return double.TryParse(input, out double variable);
        }
        public static bool YesNo(string input)
        {
            input.ToLower();
            if (input == "yes" || input == "y" || input == "no" || input == "n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
