// See https://aka.ms/new-console-template for more information

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