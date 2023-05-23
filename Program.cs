namespace InsertionSort
{

    class Program
    {
        static void Main(string[] args)
        {
            Insertion i = new Insertion();
            string[] arr = { "banana", "apple", "orange", "grape", "kiwi" };

            Console.WriteLine("Original array: ");
            i.PrintArray(arr);

            i.InsertionSort(arr);

            Console.WriteLine("Sorted array: ");
            i.PrintArray(arr);
        }
    }
}
