//Задача 2

int a, b, max;

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
    
Console.Write("Максимальное число: " + max);
Console.Write("Минимальное число: " + min);