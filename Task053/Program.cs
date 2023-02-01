/* Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void printInColor(string data, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.Write(data);
  Console.ResetColor();
}
void printHeardOfArray(int length)
{
  Console.Write(" \t");
  for (int i = 0; i < length; i++)
  {
    printInColor (i + "\t", ConsoleColor.DarkGreen);
  }
  Console.WriteLine();
}

void printArray(int[,] array)
{
  printHeardOfArray(array.GetLength(1));
  for (int i = 0; i < array.GetLength(0); i++)
  {
    printInColor(i + "\t", ConsoleColor.Cyan);
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  Console.WriteLine("--------------------------");
}

int [,] swappedRows(int [,]array, int row1, int row2)
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int tmp = array[row1,i];
    array[row1,i] = array [row2,i];
    array [row2,i] = tmp;
  }
  return array;
}
int[,] array = generate2DArray(5, 3, -5, 10);
printArray(array);
int [,] swappedArray = swappedRows (array,0,array.GetLength(0) -1);
printArray(swappedArray );