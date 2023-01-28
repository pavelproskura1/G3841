// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

//считываем первое число
Console.WriteLine("Введите число: ");

    int num = Convert.ToInt32(Console.ReadLine());
    int remDiv = num % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
