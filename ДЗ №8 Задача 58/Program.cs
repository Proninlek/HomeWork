//Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


int[,] SecondMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] FirstMatrix(int p, int k, int minValue, int maxValue)
{
    int[,] result = new int[p, k];
    for (int i = 0; i < p; i++)
    {
        for (int j = 0; j < k; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int r = 0; r < resultMatrix.GetLength(0); r++)
    {
        for (int s = 0; s < resultMatrix.GetLength(1); s++)
        {
            int sum = 0;
            for (int a = 0; a < firstMartrix.GetLength(1); a++)
            {
                sum += firstMartrix[r,a] * secomdMartrix[a,s];
            }
            resultMatrix[r,s] = sum;
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк первой матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов первой матрицы: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);

int[,] array = SecondMatrix(row, col, 0, 10);
int[,] array2 = FirstMatrix(row2, col2, 0, 10);
int[,] resultMatrix = new int[col,row2];
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
MultiplyMatrix(array, array2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);