using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class MaxAmongMoreThanThree<T> where T : IComparable
    {
        public T[] values;

        public MaxAmongMoreThanThree(T[] values)
        {
            this.values = values;
        }

        public T[] SortValues(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T FindMax(T[] values)
        {
            //Storing max value in maxValue variable
            //this keyword used for accessing instance/class level variable
            var sortedValues = SortValues(this.values);
            return sortedValues[sortedValues.Length - 1];
        }

        public T FindMaxMethod()
        {
            var maxValue = FindMax(this.values);
            return maxValue;
        }

        //Generic method to print max value
        public void PrintMax()
        {
            var maxValue = FindMax(this.values);
            Console.WriteLine("Maximum value is : " + maxValue);
        }
    }
}
