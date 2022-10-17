/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


int SumNum(int number)
{
    int count = Convert.ToString(number).Length;
    int D = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      D = number - number % 10;
      result = result + (number - D);
      number = number / 10;
    }
   return result;
  }

int sumNum = SumNum(number);
Console.WriteLine("Сумма цифр в числе: " + sumNum);