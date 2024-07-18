using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC295HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW2.Tests
{
    [TestClass()]
    public class SingleElementFinderTests
    {
        [TestMethod()]
        public void FindSingleTest_SortedArray_OutputSingleElementt()
        {
            // Arrange - setting the test up
            int[] arr1 = { 1 };
            int[] arr2 = { 1, 1, 2 };
            int[] arr3 = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            int[] arr4 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 7, 8, 8, 9, 9 };
            int[] arr5 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 15, 15, 16, 16, 17, 20, 20, 33, 33, 35, 44, 44, 53, 53, 77, 77, 85, 85, 100, 100 };

            // Act - This is where you call the code you are wanting to test
            int result1 = SingleElementFinder.FindSingle(arr1);
            int result2 = SingleElementFinder.FindSingle(arr2);
            int result3 = SingleElementFinder.FindSingle(arr3);
            int result4 = SingleElementFinder.FindSingle(arr4);
            int result5 = SingleElementFinder.FindSingle(arr5);

            // Assert - is the outcome what you expected
            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
            Assert.AreEqual(7, result3);
            Assert.AreEqual(6, result4);
            Assert.AreEqual(17, result5);
        }
    }
}