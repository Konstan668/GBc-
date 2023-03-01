// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void countingInputNumbers(int amountNumbers)
{
    int number = 0;
    int count = 0;
    int i = 0;

    while (i < amountNumbers)
    {
        Console.WriteLine("Input number:");
        string input = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }

        if (number > 0)
        {
            count += 1;
            i++;
        }
        else
        {
            i++;
        }
    }
    Console.WriteLine($"Positive number = {count}");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Tuple<double, double> getCrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x;

    return Tuple.Create(x, y);
}



// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево

// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

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

int[] moveAraay(int[] array, string direction)
{
    int[] resultArray = new int[array.Length];
    if (direction == "left")
    {
        for (int i = 1; i < array.Length; i++)
        {
            resultArray[i - 1] = array[i];
        }
        resultArray[array.Length - 1] = array[0];

    }
    else if (direction == "right")
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            resultArray[i + 1] = array[i];
        }
        resultArray[0] = array[array.Length - 1];

    }
    else
    {
        Console.WriteLine("Error. You can choose left or right");
    }
    return resultArray;
}


// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.

// [1,2,3,3] -> [1,2,3,4]

int[] getUniqValueArray(int[] array, int min, int max)
{
    int[] resultArray = array;
    Random random = new Random();
    if (array.Length > 2)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            while ((resultArray[i] == resultArray[i - 1]) || (resultArray[i] == resultArray[i + 1]))
            {
                resultArray[i] = random.Next(min, max);
            }
        }
    }
    else if (array.Length == 2)
    {
        while (resultArray[0] == resultArray[1])
        {
            resultArray[0] = random.Next(min, max);
        }
    }
    return resultArray;

}
