// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double GetAverage(int[] nums)
{
    double sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }

    return sum / nums.Length;
}

int[] arr = {1,2,3,4};
double avg = GetAverage(arr);
Console.WriteLine(avg);

static int GetMax(int[] num)
{
    int current_max = num[0];
    for (int i = 1; i < num.Length; i++)
    {
        if (current_max < num[i])
            current_max = num[i];
    }

    return current_max;
}



int[] num = { 1, 2, 3, 4, 5, 6 };
int max = GetMax(num);
Console.WriteLine(max);
