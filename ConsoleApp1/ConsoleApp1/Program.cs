// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double CalculateAverage(int[] numbers) {
        int sum = 0;
        foreach (int num in numbers){
            sum += num;
        }
        return (double)sum / numbers.Length;
    }

static int findMax(int[] numbers) {
    int max = numbers[0];
    for(int i = 0; i< numbers.Length; i++){
        if(numbers[i] > max)
        max = numbers[i];
    }
    return max;
}
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Average: " + CalculateAverage(array));
Console.WriteLine("Fast forward merge");
Console.WriteLine("Max: " + findMax(array));
