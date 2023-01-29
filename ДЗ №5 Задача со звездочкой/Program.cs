//Задача "со звездочкой": Разобраться с алгоритмом сортировки 
//методом пузырька. Реализовать невозрастающую сортировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] massiv = new int[size];
    for (int i = 0; i < size; i++)
    {
        massiv[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massiv;
}

int[] ArrayOfNumbers(int [] massiv2) 
{
    int temp;
    for (int i = 0; i < massiv2.Length - 1; i++)
    {
        for (int j = i + 1; j < massiv2.Length; j++)
        {
            if (massiv2[i] < massiv2[j])
            {
                temp = massiv2[i];
                massiv2[i] = massiv2[j];
                massiv2[j] = temp;
            }
        }
    }
    return massiv2;
}

Console.Clear();
int[] ourArray = GetArray(4, -999, 999);
Console.WriteLine(String.Join(", ", ourArray));

ArrayOfNumbers (massiv2);
Console.WriteLine("После сортировки:");
for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i]);
    }
Console.ReadLine();