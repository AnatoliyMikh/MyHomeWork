//Задача 2

/*int a, b, max, min;

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
Console.WriteLine("Минимальное число: " + min); */

//Задача 4

int a, b, c, max;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{   
    max = a;
}
else
    max = b;

if (max > c)
{  
   Console.WriteLine("Максимальное число: " + max);
}
else
if (max < c)
{
    max = c;
    Console.WriteLine("Максимальное число: " + max);
}