//Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inputNum1!=null && inputNum2!=null)
{
//Парсим введеное число
    int number1 = int.Parse(inputNum1);
    //Парсим введеное число
    int number2 = int.Parse(inputNum2);

    if(number1==number2*number2)
    {
        Console.Write("Первое число квадрат второго!");
    }
    else
    {
        Console.Write("Первое число не квадрат второго!");
    }
}
