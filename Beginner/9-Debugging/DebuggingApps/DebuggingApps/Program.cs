using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1,2,4,5,6};
            var smallest = GetSmallest(numbers, 3);

            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallest(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list", "Cannot add null as list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count", "Count cannot be bigger than the total elements in the list");
            }

            var smallest = new List<int>();
            var buffer = new List<int>(list);

            while (smallest.Count < count)
            {
                var min = GetSmallest(buffer);
                smallest.Add(min);
                buffer.Remove(min);
            }

            return smallest;
        }
        public static int GetSmallest(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
