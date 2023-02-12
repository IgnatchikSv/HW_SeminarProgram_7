/* Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
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

int getExponentiationOfData(int userDataStart, int userDataFinish)
{
  if (userDataFinish==1)
  {
    return userDataStart;
  }
  return userDataStart * getExponentiationOfData(userDataStart,userDataFinish-1);
}

int userDataStart = getDataFromUser($"Введите значение числа A:");
int userDataFinish = getDataFromUser($"Введите значение числа B:");
int multipl = getExponentiationOfData(userDataStart,userDataFinish);
Console.WriteLine ($"Число {userDataStart} в степени числа {userDataFinish} - {multipl}");
