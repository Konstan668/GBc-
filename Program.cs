// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Ex19(int num)
{
    string number = num.ToString();
    bool flag = false;
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] == number[number.Length - 1 - i])
        {
            flag = true;
        }
        else
        {
            flag = false;
        }
    }
    return (flag ? "yes" : "no");
}


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Ex21(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return Math.Round(result, 2);
}


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

List<int> Ex23(int num)
{
    List<int> list = new List<int>();
    for (int i = 1; i <= num; i++)
    {
        list.Add(i * i * i);
    }
    return list;
}

Console.WriteLine(string.Join(", ", Ex23(3)));