namespace Assignment
{
    internal class Program
    {
        // Function to calculate the sum of digits
        static int SumOfDigits(int number)
        {
            int sum = 0;

            // Loop through each digit of the number
            while (number > 0)
            {
                sum += number % 10;  // Add the last digit to the sum
                number /= 10;         // Remove the last digit
            }

            return sum;
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            // A number less than or equal to 1 is not prime
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)  // If divisible by any number in this range, it's not prime
                {
                    return false;
                }
            }

            // If no divisors were found, the number is prime
            return true;
        }

        // Function to find the minimum and maximum values in an array using reference parameters
        static void MinMaxArray(int[] array, ref int minValue, ref int maxValue)
        {
            // Check if the array is empty
            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return;
            }

            // Initialize min and max values with the first element of the array
            minValue = array[0];
            maxValue = array[0];

            // Loop through the array to find the min and max
            foreach (int value in array)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like 
        Enter a number: 25 */

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of {number} is: {result}");

            /*Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:*/
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}

            /*Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters*/
            //int[] numbers = { 5, 2, 9, 3, 7, 1, 8 };

            //int min = 0;
            //int max = 0;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine($"The minimum value is: {min}");
            //Console.WriteLine($"The maximum value is: {max}");
        }
    }
}
