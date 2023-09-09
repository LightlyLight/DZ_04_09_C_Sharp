/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

System.Console.WriteLine("Введите любое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>100 && num<1000)
{
    int num1 = num / 10;
    int num2 = num1%10;
 //   int fullnum = (num1*10)+num2;

System.Console.WriteLine($"Второй цифрой введённого Вами числа является: {num2}");
}
else
    System.Console.WriteLine("Вы ввели не трёхзначное число: ");

