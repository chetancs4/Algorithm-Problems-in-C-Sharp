namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            BubbleSort b1 = new BubbleSort();
            Console.WriteLine("Bubble Sort");
            
            Console.WriteLine("enter how many elements you want to enter: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("enter array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in Array: ");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            b1.bubbleSort(arr);
            Console.WriteLine("Sorted array: ");
            b1.printArray(arr); 
        }
    }
}


