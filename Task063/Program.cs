/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


int getDataFromUser (string message)
{
  Console.ForegroundColor = ConsoleColor.Blue;
  Consocle.WriteLine(message);
  Console.ResetcOLOR();
  int result = int.Parse(Console.ReadLine());
}

int userData = getDataFromUser($"Введите значение числа N");
