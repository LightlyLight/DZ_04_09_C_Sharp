/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1)
{ Console.WriteLine("Сегодня Понедельник"); }
else if (dayWeek == 2)
{ Console.WriteLine("Сегодня Вторник"); }
else if (dayWeek == 3)
{ Console.WriteLine("Сегодня Среда"); }
else if (dayWeek == 4)
{ Console.WriteLine("Сегодня Четверг"); }
else if (dayWeek == 5)
{ Console.WriteLine("Сегодня Пятнице"); }
else if (dayWeek == 6)
{ Console.WriteLine("Сегодня Суббота"); }
else if (dayWeek == 7)
{ Console.WriteLine("Сегодня Воскресенье"); }
else
{ Console.WriteLine("Такого дня недели нет!"); }