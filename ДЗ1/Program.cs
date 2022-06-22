//Задача 2

int a, b, max, min;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{   
    max = b;
    min = a;
}
else
    max = a;
    min = b;
    
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);