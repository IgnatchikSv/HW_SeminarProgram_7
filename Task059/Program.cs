/* Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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


int[,] array = generate2DArray(4, 5, 1, 10);
printArray(array);