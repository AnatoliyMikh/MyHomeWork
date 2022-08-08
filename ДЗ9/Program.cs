// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
int Amount(int i, int n)
{   
    if(n > 10) 
    {   
        i++;
        return Amount(i,n / 10);
    }
    else
        return i;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int m = 1;

Console.WriteLine("Количество цифр в числе " + Amount(m, N));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.