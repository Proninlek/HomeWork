//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пяти значное число: ");
int number = int.Parse(Console.ReadLine());
int a1 = number % 100;
int a2 = number / 1000 % 10;
int a3 = number % 10;
int a4 = number / 10000;
if ((a1 == a2) || (a3 == a4))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
   Console.WriteLine($"К сожалению, число {number} не является палиндромом");
}