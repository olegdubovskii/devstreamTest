namespace DeveloperTest.ProblemSolving
{
    public static class StringExtensions
    {
        public static string ReverseString(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var chars = s.ToCharArray();
            var length = chars.Length - 1;

            for (int i = 0; i < length; i++, length--)
            {
                chars[i] ^= chars[length];
                chars[length] ^= chars[i];
                chars[i] ^= chars[length];
            }

            return new string(chars);
        }

        public static bool IsPalindrome(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            return s.Equals(ReverseString(s), StringComparison.OrdinalIgnoreCase);
        }
    }
}
