using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculator
    {
        private const string ADDITION = "+";

        private const string SUBTRACT = "-";

        private const string MULTIPLY = "*";
        /**
         * 
         * This method calculate two numbers according to the operation
         * 
         */ 
        public double calculate(string operation, double no1, double no2)
        {
            if (operation == ADDITION)
            {
                return (no1 + no2);
            }
            else if (operation == SUBTRACT)
            {
                return (no1 - no2);
            }
            else if (operation == MULTIPLY)
            {
                return (no1 * no2);
            }
            else 
            {
                return (no1 / no2);
            }            
        }
    }
}
