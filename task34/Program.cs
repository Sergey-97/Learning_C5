/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите длину массива:  ");
int size = int.Parse(Console.ReadLine()!);
Console.ResetColor ();

int[] numbers = new int[size];
RandonNumbers(numbers);

  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.Write($"В массиве:");
  PrintArray(numbers);
  Console.ResetColor ();

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
   Console.ForegroundColor = ConsoleColor.DarkMagenta;
   Console.Write($"{count} четных");
   Console.ResetColor ();

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
         if(numbers[i] != ',')
         {
                Console.Write(numbers[i]);
                if(i == numbers.Length -1)
                   Console.Write("");
                else
                 Console.Write(",");
         }
    }
    Console.Write("]");
    Console.WriteLine();
}