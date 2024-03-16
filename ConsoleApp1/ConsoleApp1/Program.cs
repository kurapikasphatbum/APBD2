// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array is null or empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
        int[] array = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(array);
        Console.WriteLine("Average: " + average);
