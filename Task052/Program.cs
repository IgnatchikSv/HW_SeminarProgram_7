/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/ 
Console.Clear();

int [,] array = new int [3,4];
void FillArray (int [,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr [i,j] = new Random().Next(10);
    }
  }
}

void PrintArray(int[,] arr)
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

void GetAvarage (int [,] arr)
{
  for (int f = 0; f < arr.GetLength(1); f++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + array[i, f]);
    }
    avarage = avarage /arr.GetLength(0);
    Console.WriteLine ($"Среднее арифметическое {f+1} столбца равно {Math.Round(avarage,1)}");
    Console.WriteLine();
}
}
FillArray (array);
PrintArray (array);
Console.WriteLine();
GetAvarage (array);
