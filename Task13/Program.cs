/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (int num >= 100)
{
    for (i = 0; i < num.Length; i++)
    int num1 = num / 10;
    int num2 = num1%10;

System.Console.WriteLine($"Третьей цифрой введённого Вами числа является: {num2}");
}
else
    System.Console.WriteLine("Это двузначное число и у него нет третьей цифры: ");

