/* Напишите программу, которая будет принимать
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/ 

Console.Clear();

int getDataFromUser (string message)
{
  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine(message);
  Console.ResetColor();
  int result = int.Parse(Console.ReadLine()!);
  return result;
}

int getSumofDigits ( int userData)
{
  if (userData == 0)
  {
    return 0;
  }
  return userData % 10 + getSumofDigits(userData/10);
}

int userData = getDataFromUser($"Введите число:");
int sumOfDigit = getSumofDigits(userData);
Console.WriteLine($"Сумма цифр числа {userData} равна {sumOfDigit}");



