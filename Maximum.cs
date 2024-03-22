using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    public class Maximum
    {
        public static void Main(string[] args)
        {
            Maximum maximum = new Maximum();
            Console.WriteLine(maximum.FindMaximum(9, 8, 7));
            Console.WriteLine(maximum.FindMaximum(6, 11, 2));
            Console.WriteLine(maximum.FindMaximum(2, 7, 99));
        }


        public int FindMaximum(int number1, int number2, int number3)
        {
            int max = number1;

            // Using CompairTo function of an Object
            if (number2.CompareTo(max) > 0) { max = number2; }
            if (number3.CompareTo(max) > 0) { max = number3; }
            return max;
        }
    }
}
