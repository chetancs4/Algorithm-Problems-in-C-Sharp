namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Binary b = new Binary();

            List<string> wordList = new List<string>
            
            {"apple", "banana", "cat", "dog", "elephant", "fish", "grape", "lemon"};

            wordList.Sort(); // Ensure the list is sorted before performing binary search

            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();

            int index = b.BinarySearch(wordList, searchWord);

            if (index != -1)
            {
                Console.WriteLine("Word found at index " + index);
            }
            else
            {
                Console.WriteLine("Word not found in the list.");
            }
        }
    }
}