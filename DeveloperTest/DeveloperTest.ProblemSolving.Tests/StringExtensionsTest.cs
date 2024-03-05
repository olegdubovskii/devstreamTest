using DeveloperTest.ProblemSolving;

namespace DeveloperTest.ProblemSolving.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ReverseString_WithValidInput_ShouldReturnReversedString()
        {
            string input = "hello";
            string expected = "olleh";

            string result = StringExtensions.ReverseString(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_WithPalindromeString_ShouldReturnTrue()
        {
            string[] inputs = { "a", "aa", "aba", "abba", "abcba", "level" };

            foreach (var input in inputs)
            {
                bool result = StringExtensions.IsPalindrome(input);
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void IsPalindrome_WithNonPalindromeString_ShouldReturnFalse()
        {
            string[] inputs = { "hello", "world", "openai", "gpt", "test" };

            foreach (var input in inputs)
            {
                bool result = StringExtensions.IsPalindrome(input);
                Assert.IsFalse(result);
            }
        }

        [TestMethod]
        [TestCategory("Performance")]
        [Timeout(1000)]
        public void ReverseString_WithLargeInput_ShouldNotExceedTimeout()
        {
            string input = new string(Enumerable.Repeat('a', 1000000).ToArray());

            Assert.IsNotNull(StringExtensions.ReverseString(input));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow("  ")]
        [DataRow("        ")]
        public void ReverseString_WithWhiteSpaceInput_ShouldReturnInput(string input)
        {
            string result = StringExtensions.ReverseString(input);
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        [DataRow(null)]
        public void ReverseString_WithNullInput_ShouldReturnEmptyString(string input)
        {
            string result = StringExtensions.ReverseString(input);
            Assert.AreEqual("", result);
        }
    }
}
