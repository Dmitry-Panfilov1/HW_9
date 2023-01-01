// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(AkkermanFunction(m, n));

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n ==0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}