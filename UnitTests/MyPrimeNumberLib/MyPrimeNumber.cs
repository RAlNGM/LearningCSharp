namespace MyPrimeNumberLib
{
    public class MyPrimeNumber
    {
        public bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var a = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= a; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}