// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. (Цифры считать справа налево).

Console.WriteLine("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
int a1 = number / 100;
int a2 = a1 % 10;
if(number < 99) 
{
    Console.WriteLine($"Третья цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра справа {a2}");
}
