/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int[,] generate2DArray(int rowLenght, int colLenght, int start, int finish)
{
  int[,] array = new int[rowLenght, colLenght];
  for (int i = 0; i < rowLenght; i++)
  {
    for (int j = 0; j < colLenght; j++)
    {
      array[i, j] = new Random().Next(start, finish + 1);
    }
  }
  return array;
}

void printArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int SumStringElementsOfArray(int[,] array, int i)
{
  int sumString = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumString += array[i, j];
  }
  return sumString;
}

int getMinSumString(int[,] array)
{
  int sumString = SumStringElementsOfArray(array, 0);
  int minSumString = 0;
  for (int i = 1; i < array.GetLength(0); i++)
  {
    int tempSumString = SumStringElementsOfArray(array, i);
    if (sumString > tempSumString)
    {
      sumString = tempSumString;
      minSumString = i;
      Console.WriteLine($"\n{minSumString + 1} строкa с наименьшей суммой элементов - {sumString}");
      Console.WriteLine();
    }
  }
  return minSumString;
}

int[,] array = generate2DArray(4, 5, 0, 10);
printArray(array);

int minSumString = getMinSumString(array);
