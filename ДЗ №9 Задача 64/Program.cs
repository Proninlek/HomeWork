//Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = 1;
    
    Console.Write($"Натуральные числа: ");
    Console.WriteLine(Number(n, m));
}

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}
Main();