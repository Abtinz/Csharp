using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Calculator
    {
        

        public static float Average(float firstNumber , float secondNumber) {
            float result = (firstNumber + secondNumber)/2; 
            return result;
        }

        public static float Average(float firstNumber, float secondNumber , float thirdNumber)
        {
            float result = (firstNumber + secondNumber + thirdNumber) / 3;
            return result;
        }

        public static float Average(float firstNumber, float secondNumber, float thirdNumber,float fourthNumber)
        {
            float result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            return result;
        }

    }
}
