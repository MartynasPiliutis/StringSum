using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public class StringSum(string num1, string num2)
    {
        private readonly string num1 = num1;
        private readonly string num2 = num2;

        internal string Sum(string? num1, string? num2)
        {
            int number1 = 0;
            int number2 = 0;

            Int32.TryParse(num1, out number1);
            Int32.TryParse(num2, out number2);

            return (number1 + number2).ToString();
        }
    }
}
