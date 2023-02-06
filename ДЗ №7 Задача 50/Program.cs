//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(1, 10);
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();   
    }
}

void SearchElement (int [,] nextelement, int usernumber)
{
    bool element = false;
    for (int i = 0; i < nextelement.GetLength(0); i++)
    {        
        for (int j = 0; j < nextelement.GetLength(1); j++)
        {
            if (nextelement [i,j] == usernumber)
            Console.WriteLine("Введенное Вами число находиться по координатам" +" " + i +";" + j);
            element = true;
        }
    }
    if (!element)
    Console.WriteLine("Введенного числа в массиве нет");
}

Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите интересующее Вас число: ");
int number = int.Parse(Console.ReadLine()!);
int[,] arr = new int[m, n];
FillArrayRandomNumbers (arr);
SearchElement (arr, number);
