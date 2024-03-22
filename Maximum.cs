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
            Console.WriteLine("Integer type values");
            Console.WriteLine(maximum.FindMaximum(9, 8, 7));
            Console.WriteLine(maximum.FindMaximum(6, 11, 2));
            Console.WriteLine(maximum.FindMaximum(2, 7, 99));
            Console.WriteLine("Float type values");
            Console.WriteLine(maximum.FindMaximum(7.9, 8.7, 7.125));
            Console.WriteLine(maximum.FindMaximum(6.6, 11.11, 2.9));
            Console.WriteLine(maximum.FindMaximum(9.7, 9.8, 9.9));
        }

        public T FindMaximum<T>(T number1, T number2, T number3) where T : IComparable<T>
        {
            T max = number1;

            // Using CompairTo function of an Object
            if (number2.CompareTo(max) > 0) { max = number2; }
            if (number3.CompareTo(max) > 0) { max = number3; }
            return max;
        }
    }
}
