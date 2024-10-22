using System;

namespace QuickSort
{
    class Program
    {
        // Method to perform Quick Sort on an array
        private static void QuickSort(int[] arr, int left, int right) 
        {
            // Check if there are elements to sort
            if (left < right)
            {
                // Find the pivot index
                int pivot = Partition(arr, left, right);

                // Recursively sort elements on the left and right of the pivot
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        // Method to partition the array
        private static int Partition(int[] arr, int left, int right)
        {
            // Select the pivot element
            int pivot = arr[left];

            // Continue until left and right pointers meet
            while (true) 
            {
                // Move left pointer until a value greater than or equal to pivot is found
                while (arr[left] < pivot)
                {
                    left++;
                }

                // Move right pointer until a value less than or equal to pivot is found
                while (arr[right] > pivot)
                {
                    right--;
                }

                // If left pointer is still smaller than right pointer, swap elements
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    // Swap elements
                    (arr[left], arr[right]) = (arr[right], arr[left]);
                }
                else 
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }

        static void Main()
        {
            int[] arr = { 2, 5, -9, 12, 0, 18, 12, 87, 31, 27, 1 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", arr));

            // Call Quick Sort to sort the array
            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array:");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

