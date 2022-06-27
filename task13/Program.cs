//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit3 = -1; //несуществующее значение

while (number > 99)
{
    digit3 = number % 10;
    number = number / 10;
}

if (digit3 != -1)
{
    Console.WriteLine(digit3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
