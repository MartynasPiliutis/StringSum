namespace StringSum
{
    public class Tests
    {
        private StringSum _stringSum;

        [SetUp]
        public void Setup()
        {
            string num1 = "";
            string num2 = "";

            _stringSum = new StringSum(num1, num2);
        }

        [TestCase("", "", ExpectedResult = "0")]
        [TestCase("", null, ExpectedResult = "0")]
        [TestCase(null, null, ExpectedResult = "0")]
        public string ReturnZeroIfTheStringIsEmptyOrNull(string? num1, string? num2)
        {
            return _stringSum.Sum(num1, num2);
        }
    }
}