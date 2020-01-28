using System;
using System.Linq;

namespace MostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array values sperated by , ");
            string[] a = Array.ConvertAll(Console.ReadLine().ToString().Split(','), Convert.ToString);
            Console.WriteLine("Result is : " + GetMostFrequent(a));
        }
        private static string GetMostFrequent(string[] arr)
        {
            var query = arr.GroupBy(arr => arr).OrderByDescending(x => x.Count()).Select(x => x.Key);
            return query.FirstOrDefault();
        }
    }
}
