// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёх значное число: ");
int number = int.Parse(Console.ReadLine());
int a1 = number / 10;
int a2 = a1 % 10;
Console.WriteLine($"Вторая цифра числа {number} -> {a2}");
