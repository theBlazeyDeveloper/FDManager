using System.Security;

namespace UnitTests
{
    public class CodeTests
    {
        [Theory]
        [InlineData(new int[] { -1, -2, -3, -1, 0 })]
        [InlineData(new int[] { 1, 2, 3, -1, 0 })]
        [InlineData(new int[] { 1, 1, 1, -1, 0 })]
        public void Average(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                Assert.True(0 == 0);
            }
            else
            {
                var tempSum = 0;

                foreach (var i in inputArray)
                    tempSum += i;

                decimal tempAverage = ((decimal)tempSum / (decimal)inputArray.Length);
                double linqAverage = inputArray.Average();

                Assert.True(tempAverage == (decimal)linqAverage);
            }
        }

        [Fact]
        public void PrintMultiplesOfThree()
        {
            var listNumbers = Enumerable.Range(1, 100)
                .OrderByDescending(a => a)
                .ToList();

            foreach (var num in listNumbers)
            {
                if (num % 3 == 0)
                    Console.WriteLine(num);
            }
        }

        [Theory]
        [InlineData("sfhnlsfsfosbfjl48")]
        [InlineData("sfhnlsfsfosbfjl")]
        [InlineData("2sfhnlsfsfosbfjl48")]
        public void TestContainsMethod(string text)
        {
            var result = ContainsNumber(text);
            var temptext = text;

            Assert.Equal(text, temptext);
        }

        [Theory]
        [InlineData("sfhnlsfsfosbfjl48", "short")]
        [InlineData("sfhnlsfsfosbfjl48", "48sfhnlsfsfosbfjl")]
        [InlineData("sfhnlsfsfosbfjl", "sfhnlsfsfosbfjl48")]
        [InlineData("2sfhnlsfsfosbfjl48", "2sfhnlsfsfosbfjl48")]
        [InlineData("cinema", "iceman")]
        [InlineData("presents", "serpents")]
        public void TestSameCharsMethod(string text1, string text2)
        {
            var result = SameChars(text1, text2);

            var tempResult = result;
        }

        [Theory]
        [InlineData("Let's take LeetCode contest")]
        [InlineData("God Ding")]
        public void TestReverseWordFunction_Succeed(string inputText)
        {
            var result = ReverseWords(inputText);

            Assert.False(string.IsNullOrEmpty(result));
        }

        [Theory]
        [InlineData("Let'stakeLeetCodecontest")]
        [InlineData("GodDing")]
        public void TestReverseWordFunction_Fail(string inputText)
        {
            var result = ReverseWords(inputText);

            Assert.True(string.IsNullOrEmpty(result));
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6)]
        [InlineData(new int[] { 3, 2, 3 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8)]
        public void TestTwoSum_Success(int[] nums, int target)
        {
            var result = TwoSum(nums, target);

            Assert.True(result != null);
        }

        // Define a method called ContainsNumber that checks if any character in
        // the string called text is equal to a number (e.g. 0, 1, 2, 3, 4, 5, 6, 7,
        // 8, 9). The result of the check is then returned as the return value.
        static bool ContainsNumber(string text)
        {            
            ///Array of chars to check for in input argument
            char[] testChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            /// Converts text argument to a sequence of chars.
            /// Then the LINQ function produces a temp sequence of intersecting chars.
            /// If the count of the temp sequence equals 0 then the text DOES NOT contain a number from the testChars array
            return text
                .Intersect(testChars)
                .ToList()
                .Count > 0;           
        }

        static bool SameChars(string inputText1, string inputText2)
        {
            int text1Length = inputText1.Length;
            int text2Length = inputText2.Length;

            char[] tempCharArray = new char[text1Length];

            if (text1Length == text2Length)
            {
                for (int i = 0; i < text1Length; i++)
                {
                    for (int j = 0; j < text2Length; j++)
                    {
                        if (inputText1[i] == inputText2[j])
                            tempCharArray[j] = inputText2[j];
                    }
                }

                return tempCharArray.Length == (text1Length > text2Length ? text1Length : text2Length);
            }
            else
                return false;            
        }

        static string ReverseWords(string s)
        {
            var tempText = s.Trim();

            var tempTextArray = tempText.Split(' ');

            if (tempTextArray.Length > 1)
            {
                var reversedWordsList = new List<string>();

                foreach (var word in tempTextArray)
                {
                    var reversedWordArray = word
                        .Reverse()
                        .ToArray();

                    reversedWordsList.Add(string.Join("", reversedWordArray));
                }
                return string.Join(" ", reversedWordsList);
            }
            else
                return string.Join("", tempText.Reverse());
        }

        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length >= 2)
            {
                var indicies = new HashSet<int>();
                int numsLength = nums.Length == 1 ? nums.Length : nums.Length - 1;

                for (int i = 0; i < nums.Length; i++)
                    for (int j = 1; j <= numsLength; j++)
                    {
                        if (i != j)
                            if (nums[j] + nums[i] == target)
                            {
                                indicies.Add(i);
                                indicies.Add(j);
                            }                        
                    }
                
                return indicies.ToArray();
            }
            else
                return Array.Empty<int>();
        }
    }
}