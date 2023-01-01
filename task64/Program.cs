// Задайте значение N, напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью реурсии.

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

NaturalNumbersList(n);

void NaturalNumbersList(int number)
{
    if (number == 1)
    {
        Console.Write("1 ");
        return;
    }
    
    Console.Write(number + ", ");    // Если сначала вызвать функцию  NaturalNumbersList(number - 1),
    NaturalNumbersList(number - 1);  // а потом дать команду Console.Write(number + ", "), то числа выведутся в порядке возрастания.
}
