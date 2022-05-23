using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class MaxAmongThreeGenericClass<T> where T : IComparable
    {
        //Declaring class/instance level generic variables
        T val1, val2, val3;

        //Generic constructor : parameterized
        public MaxAmongThreeGenericClass(T val1, T val2, T val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
        }

        //Declaring generic method for calculation
        public static T MaxAmongThree(T val1, T val2, T val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0)
            {
                return val1;
            }
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0)
            {
                return val2;
            }
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0)
            {
                return val3;
            }
            return val1;
        }

        //Internal method to pass three instance variables
        public T TestMaximum()
        {
            T maxTest = MaxAmongThreeGenericClass<T>.MaxAmongThree(this.val1, this.val2, this.val3);
            return maxTest;
        }
    }
}
