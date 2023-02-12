/*Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int getDataFromUser(string message)
{
  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine(message);
  Console.ResetColor();
  int result = int.Parse(Console.ReadLine()!);
  return result;
}

void printRange(int userData)
{
  if (userData == 0)
  {
    return;
  }
  Console.Write(userData + " ");
  printRange(userData - 1);
}

int userData = getDataFromUser($"Введите значение числа N:");
printRange(userData);