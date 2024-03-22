using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum<int> integer = new Maximum<int>(8, 3, 9, 7, 11);
            Maximum<double> @double = new Maximum<double>(6.3, 8.9, 33.5);
            Maximum<string> @string = new Maximum<string>("yash", "raki", "banana");
        }
    }
}