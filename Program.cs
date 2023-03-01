// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Н
// апишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] getRandomArray(int min, int max, int size)
{
    int[] resultArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {

        resultArray[i] = random.Next(min, max);
    }
    return resultArray;
}

int getCountEvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count += 1;
        }
    }
    return count;

}



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int getSumOfEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int getSubtractionMaxMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    foreach (int i in arr)
    {
        if (i < min)
        {
            min = i;
        }
        else if (i > max)
        {
            max = i;
        }
    }


    return max - min;
}


