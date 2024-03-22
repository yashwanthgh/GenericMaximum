using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    public class Maximum<T> where T : IComparable<T>
    {
        public Maximum(params T[] values)
        {
            FindMaximum(values);
        }
        private T? FindMaximum<T>(params T[] values)
        {
            List<T> list = new();

            foreach (T item in values)
            {
                list.Add(item);
            }
            list.Sort();
            T max = list[list.Count - 1];
            Console.WriteLine($"The max value is {max}");
            return max;
        }
    }
}
