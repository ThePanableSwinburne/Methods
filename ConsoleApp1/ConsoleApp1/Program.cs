using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            CalculateDigitsInNumber(1234);
        }

        static void SayHello()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }

        static void Welcome(string pName)
        {
            Console.WriteLine($"Welcome friend {pName} !");
            Console.WriteLine("Have a nice day!");
        }

        static void AddTwoNums(int n1, int n2)
        {
            Console.WriteLine($"The sum of two numbers is : {n1 + n2}");
        }

        static void NumberOfSpacesInString(string value)
        {
            Console.WriteLine($"{value} contains {value.Count(Char.IsWhiteSpace)} spaces");
        }

        static void CalculateArrayElements(int[] array)
        {
            int total = 0;
            foreach (int value in array)
            {
                total += value;
            }

            Console.WriteLine($"The sum of the elements of the array is {total}");
        }

        static void SwapNumbers(ref int num1, ref int num2)
        {
            int originalNum = num1;
            num1 = num2;
            num2 = originalNum;

            Console.WriteLine($"Now the 1st number is: {num1}, and the 2nd number is : {num2}");
        }

        static void RaiseNumber(int baseNum, int exponentNum)
        {
            Console.WriteLine($"So, the number {baseNum} ^ (to the power) {exponentNum} = {MathF.Pow(baseNum, exponentNum)}");
        }

        static void DisplayFibonacci(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Enter a number greater than 2");
                return;
            }

            int firstNumber = 0, secondNumber = 1, nextNumber = 0;
            string sequence = "";
            sequence += "01";

           

            for (int i = 2; i < n; i++)
            {

                nextNumber = firstNumber + secondNumber;
                sequence += nextNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;

            }

            Console.WriteLine(sequence);
        }

        static void isPrime(int number)
        {
            int factors = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number%i == 0)
                {
                    factors++;
                }
            }

            if (factors == 2)
            {
                Console.WriteLine($"{number} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number");
            }
        }

        static void CalculateDigitsInNumber(int number)
        {
            int result = 0;
            string numberToString = number.ToString();
            foreach (char digit in numberToString)
            {
                Console.WriteLine(digit);
                result += Convert.ToInt32(digit.ToString());
            }

            Console.WriteLine($"The sum of the digits of the number {number} is {result}");
        }

        static int RecursiveFactorial(int num)
        {
            if (num == 0)
                return 1;
            return num * RecursiveFactorial(num - 1);
        }

        public static int FindFibonacciRecursively(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FindFibonacciRecursively(n - 1) + FindFibonacciRecursively(n - 2);
        }


    }
}
