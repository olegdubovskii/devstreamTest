using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTest.ProblemSolving
{
    public static class ArrayExtensions
    {
        public static IEnumerable<int> MissingElements(this int[] arr)
        {
            List<int> missingElements = new List<int>();
            if (arr.Length == 0)
            {
                return missingElements;
            }

            int temporaryElement = arr[0];
            int arrayIndex = 0;

            while (temporaryElement <= arr[arr.Length - 1])
            {
                if (arrayIndex < arr.Length && arr[arrayIndex] == temporaryElement)
                {
                    temporaryElement++;
                    arrayIndex++;
                }
                else
                {
                    missingElements.Add(temporaryElement);
                    temporaryElement++;
                }
            }

            return missingElements;
        }
    }
}
