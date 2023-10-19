/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n)*/

int Ackermann(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Ackermann(m - 1, 1);
else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine("Введите значения m и n, где m и n > 0:");
int Ack1 = Convert.ToInt32(Console.ReadLine());
int Ack2 = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(Ack1, Ack2);
Console.WriteLine($"Ackermann({Ack1}, {Ack2}) = {result}");
