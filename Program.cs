// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = n % 100;
int b = a / 10;

Console.WriteLine(b);




