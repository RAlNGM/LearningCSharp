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
            List<bool> expected_general = new List<bool>() { true, false, false };

            // ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))

            List<bool> expected_year_mod_400_equal_zero = new List<bool>() { false, false, false };  // a
            List<bool> expected_year_mod_100_not_equal_zero = new List<bool>() { true, true, true }; // b
            List<bool> expected_year_mod_4_equal_zero = new List<bool>() { true, false, false };     // c
            List<bool> expected_b_and_c = new List<bool>() { true, false, false };                   // d
            List<bool> expected_a_and_d = new List<bool>() { true, false, false };

            List<int> years = new List<int>() { 2020, 2021, 2022 };

            LeapYear year_is_leap = new LeapYear();
            for (int i = 0; i < years.Count; i++)
            {
                bool actual_a = year_is_leap.expected_a_func(years[i]);
                bool actual_b = year_is_leap.expected_b_func(years[i]);
                bool actual_c = year_is_leap.expected_c_func(years[i]);
                bool actual_d = year_is_leap.expected_b_and_c_func(years[i]);
                bool actual_a_and_d = year_is_leap.expected_general_func(years[i]);

                Assert.AreEqual(expected_year_mod_400_equal_zero[i], actual_a);
                Assert.AreEqual(expected_year_mod_100_not_equal_zero[i], actual_b);
                Assert.AreEqual(expected_year_mod_4_equal_zero[i], actual_c);
                Assert.AreEqual(expected_b_and_c[i], actual_d);
                Assert.AreEqual(expected_a_and_d[i], actual_a_and_d);

                Console.WriteLine($"expected_year_mod_400_equal_zero:     {years[i]} {expected_year_mod_400_equal_zero[i]} === {actual_a}");
                Console.WriteLine($"expected_year_mod_100_not_equal_zero: {years[i]} {expected_year_mod_100_not_equal_zero[i]} === {actual_b}");
                Console.WriteLine($"expected_year_mod_4_equal_zero:       {years[i]} {expected_year_mod_4_equal_zero[i]} === {actual_c}");
                Console.WriteLine($"expected_b_and_c:                     {years[i]} {expected_b_and_c[i]} === {actual_d}");
                Console.WriteLine($"expected_a_and_d:                     {years[i]} {expected_a_and_d[i]} === {actual_a_and_d}");
            }
        }
    }
}