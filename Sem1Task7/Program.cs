//Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
// //Проверяем, чтобы данные были не пустые
 if(imputNumLine!=null)
{
//Парсим введеное число
    int imputNumberA = int.Parse(imputNumLine);
    int LastDigit = imputNumberA%10;

    Console.WriteLine(LastDigit);
}