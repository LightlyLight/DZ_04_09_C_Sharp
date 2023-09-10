/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int length = num/100;
if (num >= 100)
{
    for (int i = 0; i < length; i++)
    {
        if (num/100 >= 1 && num/100 <= 9)
        {
            int num1 = num/10;
            int num2 = num%10;
            System.Console.WriteLine($"Третьей цифрой введённого Вами числа является: {num2}");
            break;
        }
        else
            num = num/10;  
    }
   
}   
else
    System.Console.WriteLine("Это двузначное число и у него нет третьей цифры: ");