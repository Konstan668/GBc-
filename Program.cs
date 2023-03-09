using System;
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] Get2DArray(int rows, int columns, int minNumber, int maxNumber)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(minNumber, maxNumber);
        }
    }


    return array;
}


void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

int GetIndex(int[,] array, (int, int) index)
{
    try
    {
        return array[index.Item1, index.Item2];
    }
    catch
    {
        Console.WriteLine("Элемента с данными индексами в массиве нет");
        return 0;
    }

}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

string GetAverageNumberOfColumn(int[,] array)
{
    double sum = 0;
    var avarageNumbersList = new List<double>();
    for (int i = 0; i < array.GetLongLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        avarageNumbersList.Add(Math.Round(sum / array.GetLength(0), 1, MidpointRounding.ToZero));
        sum = 0;
    }
    return string.Join("; ", avarageNumbersList);
}


// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. Определите, 
// есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

string IsColumn(int[,] array)
{
    int sumCornerNumbers = 0;
    int sumNumbersInColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumCornerNumbers += array[i, 0] + array[i, array.GetLength(1) - 1];
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumNumbersInColumn += array[j, i];
        }
        if (sumCornerNumbers < sumNumbersInColumn)
        {
            return "yes";
        }
        else
        {
            sumNumbersInColumn = 0;
        }

    }
    return "no";

}


// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Вывести первые n строк треугольника Паскаля. 
// Реализовать вывод в виде равнобедренного треугольника.

// N = 7 -> https://ibb.co/yWPZbG7

int GetFactorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    else
    {
        return number * GetFactorial(number - 1);
    }
}


List<object> GetRowInPascalTriangle(int row, int triangleHight)
{
    List<object> pascalTriangleRow = new List<object>();
    for (int j = 0; j < triangleHight - row; j++)
    {
        pascalTriangleRow.Add(" ");
    }
    int rowLenght = row + 1;
    int number = 0;
    for (int i = 0; i < rowLenght; i++)
    {
        number = GetFactorial(row) / (GetFactorial(i) * GetFactorial(row - i));
        pascalTriangleRow.Add(number);
        if (i != rowLenght - 1)
        {
            pascalTriangleRow.Add(" ");
        }
    }
    for (int n = 0; n < triangleHight - row; n++)
    {
        pascalTriangleRow.Add(" ");
    }
    return pascalTriangleRow;

}


void PascalTriangle(int number)
{
    for (int i = 0; i < number; i++)
    {
        List<object> row = GetRowInPascalTriangle(i, number);
        for (int j = 0; j < number * 2; j++)
        {
            Console.Write(Convert.ToString(row[j]));
        }
        Console.WriteLine();
    }
}


void Test()
{
    Console.WriteLine("Задача 47");
    ShowArray(Get2DArray(3, 4, 0, 9));

    Console.WriteLine("Задача 50");
    int[,] arrayEx50Ex52 = {{1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4}};
    (int, int) index1 = (1, 1);
    (int, int) index2 = (1, 7);

    Console.WriteLine($"Index = {index1}  {GetIndex(arrayEx50Ex52, index1)}");
    Console.WriteLine($"Index = {index2}  {GetIndex(arrayEx50Ex52, index2)}");

    Console.WriteLine("Задача 52");
    Console.WriteLine(GetAverageNumberOfColumn(arrayEx50Ex52));

    Console.WriteLine("Дополнительная задача 1");
    int[,] array1 = {{4, 4, 7, 5},
                     {4, 3, 5, 3},
                     {8, 1, 6, 8}};

    int[,] array2 = {{2, 4, 7, 2},
                     {4, 3, 5, 3},
                     {2, 1, 6, 2}};
    Console.WriteLine(IsColumn(array1));
    Console.WriteLine(IsColumn(array2));

    Console.WriteLine("Дополнительная задача 2");
    PascalTriangle(7);
}

Test();