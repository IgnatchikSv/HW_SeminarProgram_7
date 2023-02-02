/*Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void getBubbleSortedArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int l = 0; l < array.GetLength(1) - 1; l++)
      {
        if (array[i, l] < array[i, l + 1])
        {
          int tmp = array[i, l + 1];
          array[i, l + 1] = array[i, l];
          array[i, l] = tmp;
        }
      }
    }
  }
}
  int[,] array = generate2DArray(4, 5, 0, 10);
  printArray(array);
  getBubbleSortedArray(array);
  Console.WriteLine();
  printArray(array);