﻿
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//считываем первое число
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;

if(number > 1)
{
    while(even <= number)
    {
        Console.Write(even + " ");
        even = even + 2;
    }
}