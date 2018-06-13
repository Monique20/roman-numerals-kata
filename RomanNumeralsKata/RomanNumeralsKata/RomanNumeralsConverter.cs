using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsConverter
    {
        public string Convert(int number)
        {
            int[] values = { 40, 20, 10, 9, 5, 4 };
            string[] symbols = { "XL","XX", "X", "IX", "V", "IV" };

            StringBuilder result = new StringBuilder();
            int balance = number;
           
            for (int i = 0; i < values.Length; i++)
            {
                balance = AppendRomanNumerals(balance, values[i], symbols[i], result);
            }
            for (int i = 0; i < balance; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }

        private int AppendRomanNumerals(int number, int values, string symbols, StringBuilder builder)
        {
            int result = number;
            
            if (result >= values)
            {
                builder.Append(symbols);
                result -= values;
            }
            return result;
        }

    }
}