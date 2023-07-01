using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            Predicate<int> isEvenDelegate = IsEven;
            Predicate<int> isOddDelegate = IsOdd;
            Predicate<int> isPrimeDelegate = IsPrime;
            Predicate<int> isFibonacciDelegate = IsFibonacci;

            bool isEven = PerformOperation(number, isEvenDelegate);
            Console.WriteLine($"{number} є парним: {isEven}");

            bool isOdd = PerformOperation(number, isOddDelegate);
            Console.WriteLine($"{number} є непарним: {isOdd}");

            bool isPrime = PerformOperation(number, isPrimeDelegate);
            Console.WriteLine($"{number} є простим числом: {isPrime}");

            bool isFibonacci = PerformOperation(number, isFibonacciDelegate);
            Console.WriteLine($"{number} є числом Фібоначчі: {isFibonacci}");

            Console.ReadKey();
        }
        static bool PerformOperation(int number, Predicate<int> operation)
        {
            return operation(number);
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }
}
