/*Задача1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
void SeriesNumbers(int number)
{
    if (number == 1) 
    {
        Console.Write($"{number}, ");
        return;
    }
    Console.Write($"{number}, ");
    SeriesNumbers(number - 1);
}

Console.WriteLine("Input N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num1} -> ");
SeriesNumbers(num1);
Console.WriteLine();
