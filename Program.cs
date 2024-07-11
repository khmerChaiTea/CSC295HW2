using System;

namespace CSC295HW2
{
    public class Program
    {
        // Function to find the single element in the sorted array
        public static int FindSingleElement(int[] nums)
        {
            int low = 0;                    // Initialize low pointer
            int high = nums.Length - 1;     // Initialize high pointer

            // Perform binary search
            while (low <=high)
            {
                // If there's only one element left, it must be the single element
                if (low == high)
                    return nums[low];

                int mid = (low + high) / 2; // Calculate mid index

                // Check if mid index is evem
                if (mid % 2 == 0)
                {
                    // If nums[mid] equals nums[mid + 1], single element is to the right of mid
                    if (nums[mid] == nums[mid + 1])
                    {
                        low = mid + 2;      // Adjust low pointer
                    }
                    else
                    {
                        high = mid;         // Adjust high pointer
                    }
                }
                // Check if mid index is odd
                else
                {
                    // If nums[mid] equals nums[mid - 1], single element is to the left of mid
                    if (nums[mid] == nums[mid - 1])
                    {
                        low = mid + 1;      // Adjust low pointer
                    }
                    else
                    {
                        high = mid - 1;     // Adjust high pointer
                    }
                }
            }

            // If no single element is found, this should not happen in a valid input
            throw new ArgumentException("Invalid input: No single element found.");
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            int soloNum = FindSingleElement(nums);
            Console.WriteLine("Single element is: " + soloNum); // Output: 7
        }
    }
}
