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
            Console.WriteLine("String type values");
            Console.WriteLine(maximum.FindMaximum("sachin", "bharath", "kavya"));
            Console.WriteLine(maximum.FindMaximum("rakesh", "smitha", "samarth"));
            Console.WriteLine(maximum.FindMaximum("omkar", "shivu", "sameer"));
        }


        public T? FindMaximum<T>(params T[] values) where T : IComparable<T>
        {
            List<T> list = new();

            foreach (T item in values)
            {
                list.Add(item);
            }
            list.Sort();
            T max = list[list.Count - 1];
            return max;
        }
    }
}
