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
            string sum = "0";
            if (string.IsNullOrEmpty(num1) && string.IsNullOrEmpty(num2))
            {
                return sum;
            }

            return sum;
        }
    }
}
