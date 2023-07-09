using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer number between 5 and 15: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 5 && userInput <= 15)
            {
                int[] array = Method1(userInput);
                Console.WriteLine("\nThe elements of the array are: " + string.Join(" ", array));

                int sum = Method2(array);
                Console.WriteLine("The sum is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer between 5 and 15.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter an integer number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input. The number is too large or too small.");
        }

        Console.ReadLine();
    }

    static int[] Method1(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10, 51);
        }

        return array;
    }

    static int Method2(int[] array)
    {
        int sum = 0;

        foreach (int number in array)
        {
            sum += number;
        }

        return sum;
    }
}
