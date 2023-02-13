// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

void ex1(int number1, int number2)
{
    if (number1 > number2)
    {
        Console.WriteLine($"{number1} greater than {number2}");
    }
    else if (number2 > number1)
    {
        Console.WriteLine($"{number2} greater than {number1}");
    }
    else
    {
        Console.WriteLine("Numbers are equal");
    }
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

void ex2(int number1, int number2, int number3)
{
    int[] array = { number1, number2, number3 };
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Max = {max}");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

void ex3(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is even");
    }
    else
    {
        Console.WriteLine($"{number} is odd");
    }
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

void ex4(int number)
{
    List<int> list = new List<int>();
    int i = 1;
    while (i < number)
    {
        if (i % 2 == 0)
        {
            list.Add(i);
        }
        i++;
    }

    Console.WriteLine(string.Join(",", list));
}
