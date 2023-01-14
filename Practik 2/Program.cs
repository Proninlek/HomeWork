Console.WriteLine("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse (Console.ReadLine());
if(number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Число {number1} самое большое");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Число {number2} самое большое");
}
else
{
    Console.WriteLine($"Число {number3} самое большое");
}