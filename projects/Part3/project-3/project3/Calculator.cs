using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Calculator
    {
        public float result { get; set; }

        public void Average(float firstNumber , float secondNumber) {
             result = (firstNumber + secondNumber)/2; 
        }

        public void Average(float firstNumber, float secondNumber , float thirdNumber)
        {
            result = (firstNumber + secondNumber + thirdNumber) / 3;
        }

        public void Average(float firstNumber, float secondNumber, float thirdNumber,float fourthNumber)
        {
            result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
        }

    }
}
