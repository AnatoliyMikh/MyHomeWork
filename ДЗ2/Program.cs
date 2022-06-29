//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int n1)
{
    int receivednumber = n1%100;       
    int result = receivednumber/10;
    return result;
}
 
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
 
int res = SecondDigit(num);
Console.WriteLine("Вторая цифра: " + res);
