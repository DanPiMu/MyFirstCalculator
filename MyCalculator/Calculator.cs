using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public int Sum(int sum1, int sum2)
        {
            return sum1 + sum2;
        }
        public int Substract(int sum1, int sum2)
        {
            return sum1 - sum2;
        }
        public int Multiply(int sum1, int sum2)
        {
            return sum1 * sum2;
        }
        public int Divide(int sum1, int sum2)
        {
            return sum1 / sum2;
        }
    }
}
