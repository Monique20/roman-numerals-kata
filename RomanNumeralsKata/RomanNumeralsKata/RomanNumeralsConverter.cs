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
            int[] numbers = { 2000, 1000, 900, 500, 400, 200, 100, 90, 50, 40, 20, 10, 9, 5, 4 };
            string[] romanNumerals = { "MM", "M", "CM", "D", "CD", "CC", "C", "XC","L", "XL","XX", "X", "IX", "V", "IV" };

            StringBuilder output = new StringBuilder();
            int balance = number;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                balance = Join(balance, numbers[i], romanNumerals[i], output);
            }
            for (int i = 0; i < balance; i++)
            {
                output.Append("I");
            }

            return output.ToString();
        }

        private int Join(int number, int values, string numerals, StringBuilder output)
        {
            int result = number;
            
            if (result >= values)
            {
                output.Append(numerals);
                result -= values;
            }
            return result;
        }

    }
}