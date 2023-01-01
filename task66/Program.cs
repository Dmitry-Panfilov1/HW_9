// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма элементов равна {SumNumbers(m, n)}");

int SumNumbers(int firstNumber, int secondNumber)
{
    if (secondNumber < firstNumber)
    {
        int temp = secondNumber;
        secondNumber = firstNumber;
        firstNumber = temp;
    }
    
    if (secondNumber == firstNumber)
    {
        return firstNumber;
    }
    else
    {
       return secondNumber + SumNumbers(firstNumber, secondNumber - 1); 
    }
}