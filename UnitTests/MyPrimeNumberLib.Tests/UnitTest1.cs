using Microsoft.VisualStudio.TestPlatform.TestHost;

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

        [TestMethod]
        public void is_leap_year_test()
        {
            List<bool> excepted_ = new List<bool>()
            {
                true, false, false, false, true, false, false
            };
            List<int> years = new List<int>()
            { 
                2016, 2017, 2018, 2019, 2020, 2021, 2022
            };

            LeapYear year_is_leap = new LeapYear();
            for (int i = 0; i < years.Count; i++)
            {
                bool actual = year_is_leap.isLeapYear(years[i]);
                Console.WriteLine($"{years[i]} {excepted_[i]} === {actual}");
                Assert.AreEqual(excepted_[i], actual);
            }
        }


    }
}