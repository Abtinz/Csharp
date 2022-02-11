using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_1
{
    internal class Triangle
    {
        private float TriangleBase { set; get; }
        private float TriangleHeight { get; }

        public Triangle(float BaseValue)
        {
            TriangleBase = BaseValue;
        }

        /**
         * this method will print type of our shape
         **/

        public static void shapeType()
        {
            Console.WriteLine("Triangle");
        }

        /*
         * this methid will calculate area of Triangle
         */
        public float AreaCalculator()
        {
            float area = (TriangleBase * TriangleHeight)/2;
            return area;
        }
     }
}
