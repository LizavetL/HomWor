﻿Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
        Console.WriteLine("да");
    }
else
{
    Console.WriteLine("нет");
}
}
else
{
    Console.WriteLine("нет");
}