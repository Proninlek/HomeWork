//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


void Matrix(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
            number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int rad = 0; rad < array.GetLength(2); rad++)
            {
                array[row, col, rad] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"{array[i,j,k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов матрицы: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите радиус матрицы: ");
int rad = int.Parse(Console.ReadLine()!);

int[,,] array = new int[row, col, rad];
Matrix(array);
PrintArray(array);