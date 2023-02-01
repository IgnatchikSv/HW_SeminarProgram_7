/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
    printInColor(i + "\t", ConsoleColor.DarkGreen);
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
int getDataFromUser(string message)
{
  printInColor(message + "\n", ConsoleColor.Blue);
  int data = int.Parse(Console.ReadLine()!);
  return data;
}
bool CheckCanRotate(int rows, int cols)
{
  return rows == cols;
}

int[,] rotateMatrix (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = i; j < array.GetLength(1); j++)
    {
      int tmp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = tmp;
    }
  }
  return array;
}
int rows = getDataFromUser("Введите количество строк:");
int cols = getDataFromUser("Введите количество столбцов:");
bool canContinue = CheckCanRotate(rows, cols);
if (canContinue)
{
  int[,] array = generate2DArray(rows, cols, 0, 10);
  printArray(array);
  int[,] rotatedArray = rotateMatrix(array);
  printArray(rotatedArray);
}
else
{
  printInColor("Невозможно заменить строки на столбцы, необходима квадратная матрица", ConsoleColor.Red);
}
