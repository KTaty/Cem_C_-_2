// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int Number=Convert.ToInt32(Console.ReadLine());

int digit(int number)
{
    int digit2 = ((number % 100) / 10);
    return digit2;
}

int Result = digit(Number);
Console.WriteLine(Result);
