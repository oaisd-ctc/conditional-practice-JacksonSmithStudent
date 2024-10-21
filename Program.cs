using System;

class Program
{
    static void Main(string[] args)
    {
        // Test CheckForPositiveNegativeZero
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);

        // Test FindMinimum
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);

        // Test FindMaximum
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);

        // Test IsDivisibleBy5
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);

        // Test CheckEvenOrOdd
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);

        // Test CheckVowelOrConsonant
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');

        // Test DisplayDayOfWeek
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
    }

    static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Your number is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine("Your number is positive.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }

    static void FindMinimum(int num1, int num2, int num3)
    {
        int minimum = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine($"The minimum value is {minimum}.");
    }

    static void FindMaximum(int num1, int num2, int num3)
    {
        int maximum = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"The maximum value is {maximum}.");
    }

    static void IsDivisibleBy5(int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine($"{number} is divisible by 5.");
        }
        else
        {
            Console.WriteLine($"{number} is not divisible by 5.");
        }
    }

    static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    static void CheckVowelOrConsonant(char letter)
    {
        letter = char.ToLower(letter);
        if ("aeiou".Contains(letter))
        {
            Console.WriteLine($"{letter} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{letter} is a consonant.");
        }
    }

    static void DisplayDayOfWeek(int dayCode)
    {
        switch (dayCode)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day code.");
                break;
        }
    }
}

