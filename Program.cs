// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

void ShowEvenNumbers(int min, int max)
{
    if (min % 2 == 0)
    {
        Console.WriteLine(min);
    }
    if (min == max)
    {
        return;
    }
    ShowEvenNumbers(min + 1, max);
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumRecursion(int min, int max)
{
    if (min == max)
    {
        return max;
    }
    return min + GetSumRecursion(min + 1, max);
}

// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

int GetGreatCommonDevisor(int M, int N)
{
    if (M > N)
    {
        GetGreatCommonDevisor(N, M);
    }
    if (N % M == 0)
    {
        return M;
    }
    return GetGreatCommonDevisor(N % M, M);
}

// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

int GetAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return GetAckermann(m - 1, 1);
    }
    return GetAckermann(m - 1, GetAckermann(m, n - 1));
}


// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая выводит монотонную последовательность 
// из N элементов в виде равностороннего треугольника с помощью рекурсии

// N = 5 -> https://ibb.co/9nZgLtY

void GetRecursionTriangle(int n, int position = 0)
{
    if (n == 1)
    {
        ChangePosition(position);
        Console.Write(n);
        ChangePosition(position);
        return;
    }
    GetRecursionTriangle(n - 1, position + 1);
    Console.WriteLine();
    ChangePosition(position);
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1)
        {
            Console.Write(n);
        }
        else
        {
            Console.Write(n + " ");
        }
    }
    ChangePosition(position);

}


void ChangePosition(int position)
{
    for (int p = 0; p < position; p++)
    {
        Console.Write(" ");
    }
}


void Test()
{
    Console.WriteLine("Задача 64");
    ShowEvenNumbers(1, 5);
    Console.WriteLine();
    ShowEvenNumbers(4, 8);

    Console.WriteLine("Задача 66");
    Console.WriteLine(GetSumRecursion(1, 15));
    Console.WriteLine(GetSumRecursion(4, 8));

    Console.WriteLine("Задача 68");
    Console.WriteLine(GetGreatCommonDevisor(28, 7));

    Console.WriteLine("Дополнительная задача 1");
    Console.WriteLine(GetAckermann(3, 2));

    Console.WriteLine("Дополнительная задача 2");
    GetRecursionTriangle(5);
    Console.WriteLine();
}


Test();