//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] RandomNumbers(int size, int minValue, int maxValue)
{
    double[] massiv = new double[size];
    for (int i = 0; i < size; i++)
    {
        massiv[i] = Convert.ToDouble(new Random().Next(10000)) / 100;
    }
    return massiv;
}

double DifferentResult(double[] number)
{
    double max = number[0];
    double min = number[0];    
    double sum = 0;
    for (int j = 0; j < number.Length; j++)
    {
        if (number[j] > max)
        {
            max = number[j];
        }
        if (number[j] < min)
        {
            min = number[j];
        }
        else
        {
            sum = max - min;
        }
    }
    return sum;
}

Console.Clear();
double[] ourArray = RandomNumbers(6, 0, 100);
double result = DifferentResult(ourArray);
Console.WriteLine(String.Join(" | ", ourArray));
Console.WriteLine($"Разница между Max и Min значением равна {result:F2}");