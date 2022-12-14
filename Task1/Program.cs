// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введи трехзначное число: ");
int number = int.Parse(Console.ReadLine());
string str = Convert.ToString(number);
Console.WriteLine("Вторая цифра твоего числа: "+str[1]);