/*Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int getSumofRange(int userDataStart, int userDataFinish)
{
  if (userDataStart == userDataFinish)
  {
    return userDataStart;
  }
  int temp = userDataStart;
  return temp = temp + getSumofRange(userDataStart + 1, userDataFinish);

}

int userDataStart = getDataFromUser($"Введите значение числа M:");
int userDataFinish = getDataFromUser($"Введите значение числа N:");
int sumOfRange = getSumofRange(userDataStart, userDataFinish);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Сумма чисел от {userDataStart} до {userDataFinish} равна {sumOfRange}");
Console.WriteLine();



