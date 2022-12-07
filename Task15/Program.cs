/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7");
string DayNumber = Console.ReadLine()??"";

if (DayNumber == "1")
Console.WriteLine("Нет");
else if (DayNumber == "2")
Console.WriteLine("Нет");
else if (DayNumber == "3")
Console.WriteLine("Нет");
else if (DayNumber == "4")
Console.WriteLine("Нет");
else if (DayNumber == "5")
Console.WriteLine("Нет");
else if (DayNumber == "6")
Console.WriteLine("Да");
else if (DayNumber == "7")
Console.WriteLine("Да");

else
{
    Console.WriteLine("Неправельный ввод дня недели");
}