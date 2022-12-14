// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введи цифру дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number <= 5)
{
    Console.WriteLine("Нет");
}
else if (number > 7)
{
    Console.WriteLine("Это не день недели");
}
else
{
    Console.WriteLine("Да");
}
