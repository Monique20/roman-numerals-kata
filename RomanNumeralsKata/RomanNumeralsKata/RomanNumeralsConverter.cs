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
            int[] values = { 2000, 1000, 900, 500, 400, 200, 100, 90, 50, 40, 20, 10, 9, 5, 4 };
            string[] numerals = { "MM", "M", "CM", "D", "CD", "CC", "C", "XC","L", "XL","XX", "X", "IX", "V", "IV" };

            StringBuilder result = new StringBuilder();
            int balance = number;
           
            for (int i = 0; i < values.Length; i++)
            {
                balance = Join(balance, values[i], numerals[i], result);
            }
            for (int i = 0; i < balance; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }

        private int Join(int number, int values, string numerals, StringBuilder builder)
        {
            int result = number;
            
            if (result >= values)
            {
                builder.Append(numerals);
                result -= values;
            }
            return result;
        }

    }
}