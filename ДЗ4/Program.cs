/*//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
int SumOfDigits(int n)
{
    int sum = 0;
    int num = n;
    
    while(num > 0)
    {
        sum += num%10;
        num = num/10;
    }
    return sum;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(n));*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Massive(int n1)
{
   int[] arr = new int[n1];

    for (int i = 0; i < n1; i++) 
    {
       arr[i] = new Random().Next(n1);
    }

    for (int j = 0; j < arr.Length; j++) 
    {
       Console.Write(arr[j] + " ");
    }
}

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Massive(n1);