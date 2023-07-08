using System;

class NotPrimeException : Exception
{
    public NotPrimeException()
    {
    }

    public NotPrimeException(string message)
        : base(message)
    {
    }

    public NotPrimeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

class PrimeNumberGenerator
{
    public static void GeneratePrimeNumbers(int startingNumber, int count)
    {
        if (!IsPrime(startingNumber))
        {
            throw new NotPrimeException("Starting number is not a prime number.");
        }

        Console.WriteLine("Prime numbers starting from {0}:", startingNumber);

        int primeCount = 0;
        int currentNumber = startingNumber;

        while (primeCount < count)
        {
            if (IsPrime(currentNumber))
            {
                Console.WriteLine(currentNumber);
                primeCount++;
            }

            currentNumber++;
        }
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            PrimeNumberGenerator.GeneratePrimeNumbers(10, 5);
        }
        catch (NotPrimeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
