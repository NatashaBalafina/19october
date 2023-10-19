//*Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30*/

int SumNumbers(int numN, int numM)
{
    if(numN == numM) return numN;
    else if (numN > numM)
    {
        return numN + SumNumbers(numN - 1, numM);
    }
    else return numM + SumNumbers(numN, numM - 1);
}

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {numM}; N = {numN} -> {SumNumbers(numN, numM)}");