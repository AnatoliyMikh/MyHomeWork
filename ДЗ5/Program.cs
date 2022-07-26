// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] CreateArray(int n1)
{
   int[] arr = new int[n1];

    for (int i = 0; i < n1; i++) 
    {
       arr[i] = new Random().Next(100, 1000);
    }
    
    for (int j = 0; j < arr.Length; j++) 
    {
       Console.Write(arr[j] + " ");
    }
    return arr;
}

int FindEvenNumbers(int[] arr)
{
    int result = 0; 

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
            result++;
    }
    return result;
}

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[] massive = CreateArray(n1);
Console.WriteLine("Количество четных чисел равно " + FindEvenNumbers(massive)); 

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

int[] Massive(int n1)
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
    Console.WriteLine();
    return arr;
}
int SumOfDigits(int[] array)
{   
    int sum = 0;

    for (int i = 1; i < array.Length; i=i+2)
    {
        sum += array[i];
    }

    return sum;
}

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[] mass = Massive(n1);
Console.WriteLine("Сумма нечетных элементов равна " + SumOfDigits(mass)); 

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

double[] CreateNewArray(int r1)
{
   double[] arr = new double[r1];

    for (int i = 0; i < arr.Length; i++) 
    {
       arr[i] = new Random().Next(-100, 101);
    }
    
    for (int j = 0; j < arr.Length; j++) 
    {
       Console.Write(arr[j] + " ");
    }
    return arr;
}

double FindMaxElement(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

double FindMinElement(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

Console.Write("Введите число: ");
int r1 = Convert.ToInt32(Console.ReadLine());

double[] array = CreateNewArray(r1);
Console.WriteLine("Разница между максимальным и минимальным элементом равна " + (FindMaxElement(array)-FindMinElement(array)));