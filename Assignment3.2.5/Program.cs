using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };
            int findnum = 2;

            int index = FindIndex(numsArray, findnum);

            if (index == -1)
            {
                Console.WriteLine("Item not found");
            }
            else
            {
                Console.WriteLine($"Item {findnum} was found at index {index}");
            }

        }

        static int FindIndex<T>(T[] array, T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
