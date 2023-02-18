// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Ex1(int number)
{
    int result = (number / 10) % 10;
    return result;
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

object Ex2(int number)
{
    if ((number > (-100)) && (number < 100))
    {
        return "No third digit";
    }
    else
    {
        int num = number;
        while (num > 1000)
        {
            num /= 10;
        }
        return Math.Abs(num % 10);
    }


}



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string Ex3(int number)
{
    if ((number > 0) && (number < 8))
    {
        if ((number == 6) || (number == 7))
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
    else
    {
        return "Error. You can use value from 1 to 7";
    }
}


