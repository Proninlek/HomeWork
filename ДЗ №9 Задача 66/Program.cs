//Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int NumberSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NumberSum(m, n - 1);
}

void Main ()
{
Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов от {m} до {n} равна {NumberSum(m, n)}");
}
Main();