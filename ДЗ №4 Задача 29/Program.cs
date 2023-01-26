// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] ArrayOfNumbers(string series)
{ 
  int[] arrayOfNumbers = new int[1];
  int j = 0;
  for (int i = 0; i < series.Length; i++)
  {
    string seriesNew1 = "";
    while (series[i] != ',' && i < series.Length)
    {
      seriesNew1 += series[i];
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < series.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

void PrintArry(int[] coll) 
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

Console.Clear();
Console.Write("Введите числа, разделенные запятой: ");
string seriesOfNumbers = Console.ReadLine()!;
seriesOfNumbers = seriesOfNumbers + ",";
string seriesNew = seriesOfNumbers;
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);