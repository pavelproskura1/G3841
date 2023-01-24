//Считываем данные с консоли
string? imputLine = Console.ReadLine();

// //Проверяем, чтобы данные были не пустые
// if(imputLine!=null)
// {
// string[] dayofWeek = new string [7];
// dayofWeek[0] = "понедельник";
// dayofWeek[1] = "вторник";
// dayofWeek[2] = "среда";
// dayofWeek[3] = "четверг";
// dayofWeek[4] = "пятница";
// dayofWeek[5] = "суббота";
// dayofWeek[6] = "воскресенье";
// //Парсим введеное число
//     int imputNumber = int.Parse(imputLine);
// //Находим название дня недели по введенному номеру
//     string outDayofWeek = dayofWeek[imputNumber-1];
// //Выводим данные в консоль
//     Console.WriteLine(outDayofWeek);
// }

// Вариант 2
int imputNumber = int.Parse(imputLine);
//     string outDayofWeek = string.Empty;
// switch (imputNumber)
// {
//     case 1: outDayofWeek = "понедельник"; break;
//     case 2: outDayofWeek = "вторник"; break;
//     case 3: outDayofWeek = "среда"; break;
//     case 4: outDayofWeek = "четверг"; break;
//     case 5: outDayofWeek = "пятница"; break;
//     case 6: outDayofWeek = "суббота"; break;
//     case 7: outDayofWeek = "воскресенье"; break;
//     default: outDayofWeek = "это не день недели!"; break;
// }
// Console.WriteLine(outDayofWeek);
// //Вариант 3

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
Console.WriteLine(outDayOfWeek);