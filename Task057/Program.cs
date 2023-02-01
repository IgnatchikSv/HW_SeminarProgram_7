/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

int[] getFrequencyDictionary(int[,] array, int maxNumber)
{
  int[] result = new int[maxNumber];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result[array[i, j]] += 1;
    }
  }
  return result;
}

void printFreguencyDictionary(int[] freguencyDictionary)
{
  for (int i = 0; i < freguencyDictionary.Length; i++)
  {
    if (freguencyDictionary[i] > 0)
    {
      Console.WriteLine($"{i} встречается {freguencyDictionary[i]} раза ");
    }

  }
}

int[,] array = generate2DArray(2, 3, 0, 10);
printArray(array);
int[] frequecyDictionary = getFrequencyDictionary(array, 11);
printFreguencyDictionary(frequecyDictionary);
