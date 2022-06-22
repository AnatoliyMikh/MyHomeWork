//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine(a + " четное");
}
else
    Console.WriteLine(a + " нечетное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a, i;

Console.Write("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

i = 1;

while (i <= a)
{
    if (i%2 == 0)
    {   
        Console.Write(i + " ");
    }
    i++;
}
