// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.WriteLine("Enter number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int a = n % 100;
// int b = a / 10;

// Console.WriteLine(b);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Enter number:");
int n = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(n);
if(num.Length > 2)
{
    Console.WriteLine(num[2]);
}
else
{
    Console.WriteLine("not numb3");
}


