/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]*/


int[] mArray = new int[8];
Console.Write("Введите 8 чисел, после каждого числа нажмите Enter: ");
for(int i = 0; i < 8; i++)
  {
      mArray[i] = Convert.ToInt32(Console.ReadLine());
  }

void PrintArray (int[] arr) //вывод массива на экран
{
    int count = arr.Length;
    for(int i = 0; i <count; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив");
Console.WriteLine(" ");
PrintArray(mArray);
