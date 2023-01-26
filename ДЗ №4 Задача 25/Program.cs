//Напишите функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//Нельзя использовать библиотеку Math!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Mult(int k, int p)
{
    int result = 1;
    for(int i=1; i <= p; i++)
    {
    result = result * k;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int numberA = int.Parse (Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = int.Parse (Console.ReadLine()!);
int total = Mult(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {total}");