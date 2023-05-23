namespace MergeSort
{

    class Program
    {
        static void Main(string[] args)
        {
            MergeSorting m = new MergeSorting();
            string[] arr = { "banana", "apple", "orange", "grape", "kiwi" };

            Console.WriteLine("Original array:");
            m.PrintArray(arr);

            m.MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array:");
            m.PrintArray(arr);
        }

      
    }
}
