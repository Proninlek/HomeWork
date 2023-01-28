//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];

    for (int i = 0; i < size; i++)
    {
        massiv[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massiv;
}

int FindCount(int[] arrayToSearch)
{
    int count = 0;
    for (int j = 0; j < arrayToSearch.Length; j++)
    {
        if (arrayToSearch [j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
int[] ourArray = GetArray(6, 99, 999);
int findCounts = FindCount(ourArray);
Console.WriteLine(String.Join(", ", ourArray));
Console.WriteLine($"Мы нашли {findCounts} четных числа");