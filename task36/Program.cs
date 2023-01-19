/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.ForegroundColor = ConsoleColor.Green;
int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];
Console.ResetColor ();

FillArrayRandomNumbers(numbers);

int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

int ReadInt(string message)

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
    Console.ResetColor ();
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");
Console.ResetColor ();