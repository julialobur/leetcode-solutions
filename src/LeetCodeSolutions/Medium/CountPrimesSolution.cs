namespace LeetCodeSolutions.Medium;

public class CountPrimesSolution
{
    public int CountPrimes(int n)
    {
        if (n < 2)
        {
            return 0;
        }
        bool[] isPrime = new bool[n];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;
        for (int i = 2; i < Math.Ceiling(Math.Sqrt(n)); i++)
        {
            if (isPrime[i])
            {
                for (int multiples_of_i = i * 2; multiples_of_i < n; multiples_of_i += i)
                {
                    isPrime[multiples_of_i] = false;
                }
            }
        }
        int primeCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (isPrime[i])
            {
                primeCount++;
            }
        }
        return primeCount;
    }
}
