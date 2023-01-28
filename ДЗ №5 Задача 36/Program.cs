//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
    {
        massiv[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massiv;
}

int SumPosition(int[] number)
{
    int sum = 0;
    for (int j = 1; j < number.Length; j+=2)
    {
        sum = sum + number[j];
    }
    return sum;
}

Console.Clear();
int[] ourArray = GetArray(6, -999, 999);
int result = SumPosition(ourArray);
Console.WriteLine(String.Join(", ", ourArray));
Console.WriteLine($"Сумма чисел на нечётных позициях равна {result}");