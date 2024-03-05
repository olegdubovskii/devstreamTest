using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTest.ProblemSolving.Tests
{
    [TestClass]
    public class ArrayExtensionsTest
    {
        [TestMethod]
        public void MissingElements_WithNoMissingElements_ShouldReturnEmptyCollection()
        {
            int[] arr = { 4, 6, 9 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int> { 5, 7, 8 }, (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithMissingElementsInMiddle_ShouldReturnMissingElements()
        {
            int[] arr = { 2, 3, 4 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int>(), (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithMissingElementsAtStartAndEnd_ShouldReturnMissingElements()
        {
            int[] arr = { 1, 3, 4 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int> { 2 }, (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithSingleElementArray_ShouldReturnEmptyCollection()
        {
            int[] arr = { 1 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int>(), (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithEmptyArray_ShouldReturnEmptyCollection()
        {
            int[] arr = { };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int>(), (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithConsecutiveNumbers_ShouldReturnEmptyCollection()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int>(), (List<int>)result);
        }

        [TestMethod]
        public void MissingElements_WithMultipleMissingElements_ShouldReturnMissingElements()
        {
            int[] arr = { 2, 4, 6, 10 };

            IEnumerable<int> result = arr.MissingElements();

            CollectionAssert.AreEqual(new List<int> { 3, 5, 7, 8, 9 }, (List<int>)result);
        }
    }
}
