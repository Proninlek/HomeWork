//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
            Console.Write (result[i, j] + " ");
        }
        Console.WriteLine();
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int k = 0; k < inArray.GetLength(1); k++)
    {
        double avarage = 0;
        for (int l = 0; l < inArray.GetLength(0); l++)
        {
            avarage = (avarage + inArray[l, k]);
        }
        avarage = avarage / inArray.GetLength(0);
        Console.Write(avarage + "; ");
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, 0, 10);
Console.WriteLine();
PrintArray(array);