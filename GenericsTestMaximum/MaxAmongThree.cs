using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    //We are using CompareTo method to compare two variables
    //Usage variable1.CompareTo(variable2)
    //It returns 1: if variable1 is greater than variable2
    //returns 0: if variable1 is equal to variable2 AND
    //returns -1: if variable1 is less than variable2
    internal class MaxAmongThree
    {
        //Find maximum among three integers
        public int MaxAmongThreeInt(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return num1;
        }

        //Find maximum among three floats
        public float MaxAmongThreeFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return num1;
        }
    }
}
