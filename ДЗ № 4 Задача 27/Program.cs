﻿int result (int a)
{
    int sum = 0;    
    while (a > 0)
    {
    sum = sum + (a % 10);
    a = a / 10;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number1} равна {result (number1)}");