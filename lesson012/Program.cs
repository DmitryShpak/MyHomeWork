﻿Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int Sum(int numberN)
  {
    int count = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumN = Sum(numberN);
Console.WriteLine($"Сумма цифр в числе: " + sumN);