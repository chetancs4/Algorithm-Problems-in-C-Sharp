using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Binary
    {
        public int BinarySearch(List<string> list, string searchWord)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = searchWord.CompareTo(list[mid]);

                if (comparison == 0)
                {
                    return mid; // Word found at mid index
                }
                else if (comparison < 0)
                {
                    right = mid - 1; // Search in the left half
                }
                else
                {
                    left = mid + 1; // Search in the right half
                }
            }
            return -1; // Word not found in the list
        }
    }
}
