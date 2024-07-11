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
            while (low < high)
            {
                int mid = (low + high) / 2; // Calculate mid index

                // Ensure mid is even
                if (mid % 2 != 0)
                    mid--;

                // Check if nums[mid] and nums[mid + 1] are equal
                if (nums[mid] != nums[mid + 1])
                {
                    // Unique element is on the left side
                    high = mid;
                }
                else
                {
                    // Unique element is on the right side
                    low = mid + 2;
                }
            }

            // After the loop, low == high and points to the single element
            return nums[low];
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            int soloNum = FindSingleElement(nums);
            Console.WriteLine("Single element is: " + soloNum); // Output: 7
        }
    }
}
