namespace MyPrimeNumberLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void number_is_prime_test()
        {
            int num = 3;
            bool expected = true;

            MyPrimeNumber a_prime = new MyPrimeNumber();
            bool actual = a_prime.isPrime(num);

            Assert.AreEqual(expected, actual);
        }
    }
}