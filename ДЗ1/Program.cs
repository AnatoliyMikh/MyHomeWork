int a, b, max;

Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{   
    max = b;
}
else
    max = a;
    
Console.Write("Максимальное число: " + max);