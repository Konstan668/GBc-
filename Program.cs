// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double powFunc(int num, int pow)
{
    int result = 1;
    if (pow == 0)
    {
        return 1;
    }
    else if (pow < 0)
    {
        return 1 / powFunc(num, -(pow));
    }
    else
    {
        for (int i = 1; i <= pow; i++)
        {
            result *= num;
        }
    }
    return result;
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int countingNumbers(int number)
{
    int result = 0;
    int num = number;
    if (num < 0)
    {
        num = -num;
    }
    while ((num % 10 > 0) || (num / 10 > 0))
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

var list1 = new List<int> { 1, 2, 5, 7, 19 };
var list2 = new List<int> { 6, 1, 33 };


int[] toArray(List<int> list1, List<int> list2)
{
    int[] array = new int[list1.Count + list2.Count];
    int arrayIndex = 0;
    foreach (int i in list1)
    {
        array[arrayIndex] = i;
        arrayIndex++;
    }
    foreach (int i in list2)
    {
        array[arrayIndex] = i;
        arrayIndex++;
    }

    return array;
}

Console.WriteLine($"[{string.Join(",", toArray(list1, list2))}]");