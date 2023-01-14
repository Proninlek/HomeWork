Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int numX = num % 2;
if(numX > 0)
{
    Console.WriteLine("Это нечетное число");
}
else
{
    Console.WriteLine("Верно, это четное число");
}