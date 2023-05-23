using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Insertion
    {
        public void InsertionSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                string ch = arr[i];
                int j = i - 1;

                for (; j >= 0 && arr[j].CompareTo(ch) > 0; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = ch;
            }
        }

        public void PrintArray(string[] arr)
        {
            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
