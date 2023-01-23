//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату X0: ");
int X0 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y0: ");
int Y0 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z0: ");
int Z0 = int.Parse (Console.ReadLine()!);

Console.WriteLine("Введите координату X1: ");
int X1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y1: ");
int Y1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z1: ");
int Z1 = int.Parse (Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((X0-X1),2) + Math.Pow((Y0-Y1),2) + Math.Pow ((Z0-Z1),2));
// Я не знаю как сделать эту формулу нормально читаемой. Я узнаю, но пока так
Console.WriteLine ($"Растояние между заданными точками {result:F2}");