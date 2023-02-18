// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] GetSqrt(int num)
{
    int[] array = new int[num];
    for (int i = 1; i <= num; i++)
    {
        array[i - 1] = i * i;
    }
    return array;
}

Console.WriteLine(string.Join(",", GetSqrt(2)));