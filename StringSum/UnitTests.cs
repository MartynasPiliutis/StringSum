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
        [TestCase("", "0", ExpectedResult = "0")]
        [TestCase("0", null, ExpectedResult = "0")]
        [TestCase("11", null, ExpectedResult = "11")]
        [TestCase("", "10", ExpectedResult = "10")]
        public string ReturnZeroIfTheStringIsEmptyOrNull(string? num1, string? num2)
        {
            return _stringSum.Sum(num1, num2);
        }

        [TestCase("0", "0", ExpectedResult = "0")]
        [TestCase("0", "2", ExpectedResult = "2")]
        [TestCase("1", "2", ExpectedResult = "3")]
        [TestCase("4", "10", ExpectedResult = "14")]
        [TestCase("10", "21", ExpectedResult = "31")]
        public string TestIfSumOfNaturalNumbersIsCorrect(string? num1, string? num2)
        {
            return _stringSum.Sum(num1, num2);
        }

        [TestCase("0,1", "0", ExpectedResult = "0")]
        [TestCase("0.25", "2", ExpectedResult = "2")]
        [TestCase("1.112", "2", ExpectedResult = "2")]
        [TestCase("Abc4", "10", ExpectedResult = "10")]
        [TestCase("5gf", "2", ExpectedResult = "2")]
        [TestCase("5gf", "dfgt5", ExpectedResult = "0")]
        [TestCase("5gf", "2.214", ExpectedResult = "0")]
        public string TestIfZeroReturnedWhenNUmbersAreNotNaturalOrNetANumbers(string? num1, string? num2)
        {
            return _stringSum.Sum(num1, num2);
        }
    }
}