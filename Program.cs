// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void GetSortRowsInArray(int[,] array)
{
    int[] row = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[i, n] = row[n];
        }
    }
}


void ShowArray<T>(T[,] array)
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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

string GetNumberOfMinRow(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int numberOfRow = 1;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        minSum += array[0, n];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            numberOfRow = i;
        }
        sum = 0;
    }
    return $"{numberOfRow} строка";
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int temp = 0;
    for (int rowInMatrix1 = 0; rowInMatrix1 < matrix1.GetLength(0); rowInMatrix1++)
    {
        for (int columnInMatrix2 = 0; columnInMatrix2 < matrix2.GetLength(1); columnInMatrix2++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                temp += matrix1[rowInMatrix1, j] * matrix2[j, columnInMatrix2];
            }
            resultMatrix[rowInMatrix1, columnInMatrix2] = temp;
            temp = 0;
        }
    }
    return resultMatrix;
}

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3dArray(int firstLevelLength, int secondLevelLength, int thirgLevelLength, int minNumber, int maxNumber)
{
    int[,,] resultArray = new int[firstLevelLength, secondLevelLength, thirgLevelLength];
    Random random = new Random();
    for (int first = 0; first < firstLevelLength; first++)
    {
        for (int second = 0; second < secondLevelLength; second++)
        {
            for (int third = 0; third < thirgLevelLength; third++)
            {
                resultArray[first, second, third] = random.Next(minNumber, maxNumber);
            }
        }
    }
    return resultArray;
}


void Show3DArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write(array[i, j, n] + $"({i},{j},{n})" + " ");
            }
            Console.WriteLine();
        }

    }
}

// Show3DArrayWithIndex(Get3dArray(2, 2, 2, 10, 99));

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой):. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] GetSquareSnailArray(int strings, int columns)
{

    string[,] resultArray = new string[strings, columns];

    int left = 0;
    int right = columns - 1;
    int top = 0;
    int bottom = strings - 1;

    int numberCount = 1;
    while (top < bottom)
    {
        for (int i = left; i <= right; i++)
        {
            resultArray[top, i] = numberCount.ToString().PadLeft(2, '0');
            numberCount++;
        }

        for (int k = top + 1; k < bottom; k++)
        {
            {
                resultArray[k, right] = numberCount.ToString().PadLeft(2, '0');
                numberCount++;
            }
        }
        for (int n = right; n >= left; n--)
        {
            resultArray[bottom, n] = numberCount.ToString().PadLeft(2, '0');
            numberCount++;
        }

        for (int k = bottom - 1; k > top; k--)
        {
            resultArray[k, left] = numberCount.ToString().PadLeft(2, '0');
            numberCount++;
        }

        left += 1;
        right -= 1;
        top += 1;
        bottom -= 1;
    }
    if (strings % 2 != 0)
    {
        resultArray[left, top] = numberCount.ToString().PadLeft(2, '0');
    }
    return resultArray;
}

void Test()
{
    Console.WriteLine("Задача 54:");

    int[,] arrayEx54 = {{1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4}};
    GetSortRowsInArray(arrayEx54);
    ShowArray(arrayEx54);

    Console.WriteLine("Задача 56:");
    int[,] arrayEx56 = {{1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4},
                        {5, 2, 6, 7}};
    Console.WriteLine(GetNumberOfMinRow(arrayEx56));

    Console.WriteLine("Задача 58:");
    int[,] matrix1 = {{2, 4},
                      {3, 2}};

    int[,] matrix2 = {{3, 4},
                      {3, 3}};

    ShowArray(GetMatrixMultiplication(matrix1, matrix2));

    Console.WriteLine("Дополнительная задача");
    Show3DArrayWithIndex(Get3dArray(2, 2, 2, 10, 99));

    Console.WriteLine("Дополнительная задача 2");
    ShowArray(GetSquareSnailArray(4, 4));
}

Test();