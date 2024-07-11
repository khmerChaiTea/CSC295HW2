using System;

namespace CSC295HW2
{
    public class SingleElementFinder
    {
        // Function to find the single element in the sorted array
        public static int FindSingle(int[] arr)
        {
            int low = 0;                    // Initialize low pointer
            int high = arr.Length - 1;      // Initialize high pointer

            // Perform binary search
            while (low < high)
            {
                int mid = (low + high) / 2; // Calculate mid index

                // Ensure mid is even
                if (mid % 2 != 0)
                    mid--;

                // Check if nums[mid] and nums[mid + 1] are equal
                if (arr[mid] == arr[mid + 1])
                {
                    // Pair is intact, unique element is on the right side
                    low = mid + 2;
                }
                else
                {
                    // Pair is disrupted, unique element is on the left side
                    high = mid;
                }
            }

            // After the loop, low == high and points to the single element
            return arr[low];
        }

        public static void Main(string[] args)
        {
            // Test cases
            int[] arr1 = { 1 };                                                         // Output: 1
            int[] arr2 = { 1, 1, 2 };                                                   // Output: 2
            int[] arr3 = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };                     // Output: 7
            int[] arr4 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 7, 8, 8, 9, 9 };         // Output: 6
            int[] arr5 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };  // Output: 10

            Console.WriteLine("Single element in arr1: " + FindSingle(arr1)); // Output: 1
            Console.WriteLine("Single element in arr2: " + FindSingle(arr2)); // Output: 2
            Console.WriteLine("Single element in arr3: " + FindSingle(arr3)); // Output: 7
            Console.WriteLine("Single element in arr4: " + FindSingle(arr4)); // Output: 6
            Console.WriteLine("Single element in arr5: " + FindSingle(arr5)); // Output: 10
        }
    }
}
