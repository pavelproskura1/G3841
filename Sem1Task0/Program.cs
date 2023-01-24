
//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inputNum!=null)
 {
//     //Парсим введеное число
//     int number = int.Parse(inputNum);
//     //Находим квадрат числа
//     int result = number*number;
//     //Выводим данные в консоль
//     Console.WriteLine(result);

Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}