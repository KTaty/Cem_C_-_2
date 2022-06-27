// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите числовое значение дня недели: ");
int IndexDay = Convert.ToInt32(Console.ReadLine());

if (IndexDay == 6 || IndexDay == 7)
{
    Console.WriteLine("Да, выходные");
}
else if (IndexDay < 6 && IndexDay >0)
{
    Console.WriteLine("Нет, будни");
}
else
{
    Console.WriteLine("Введено число не соответствующее дню недели");
}