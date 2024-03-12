// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}