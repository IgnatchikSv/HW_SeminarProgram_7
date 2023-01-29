/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/ 

Console.Clear();
void FillArray (double [,] arr)
{
  Random random = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) /10;
    }
  }
}

void PrintArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        Console.Write($"{arr[i,j]} ");
      }
    Console.WriteLine();
     }
}

double [,] array = new double [3,4];
FillArray (array);
PrintArray (array);