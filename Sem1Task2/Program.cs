﻿ 
//    Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
   
    //считываем первое число
     Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
   // считываем второе число 
     Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 > num2)
    {
    Console.WriteLine("Первое число больше второго");
    }
    else if (num1 < num2)
    {
    Console.WriteLine("Первое число меньше второго");
    }
    else
    {
    Console.WriteLine("Оба числа равны");
    }
