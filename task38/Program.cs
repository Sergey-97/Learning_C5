/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */ 

  Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите длину массива  ");
int size = int.Parse(Console.ReadLine()!);
 Console.ResetColor ();
 
double[] number = new double[size];

FillArrayRandomNumbers(number);

 Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Массив: ");

PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

Console.WriteLine($"Состоящий из {number.Length} чисел, где:");
Console.WriteLine($"Максимальное = {max}");
Console.WriteLine($"Минимальное = {min}");
 Console.ResetColor ();

   Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Разница = {max - min}");
   Console.ResetColor ();

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + "; ");
        }
    Console.Write("]");
    Console.WriteLine();
}