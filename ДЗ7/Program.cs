// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomArray(int rows, int columns)
{
    double[,] newArray = new double[rows,columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(-100, 100);
    return newArray;
}

void ShowArray(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray); 

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] CreateRandomArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(0, 100);
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] arr, int str, int col)
{
    if(str < 0 || str >= arr.GetLength(0))
    {
        Console.WriteLine("нет такой строки");
    }
    else if(col < 0 || col >= arr.GetLength(1))
    {
            Console.WriteLine("нет такого столбца");
    }
    else
        Console.WriteLine(arr[str,col]);  
           
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray);

Console.Write("Введите строку элемента: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбца элемента: ");
int p1 = Convert.ToInt32(Console.ReadLine());

FindElement(myArray, r1, p1);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(0, 100);
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindАverage(int[,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        int result = 0;

        for(int j=0; j < arr.GetLength(1); j++)
        {
            result = result+ arr[i,j];
        }
        result = result / arr.GetLength(1);

        Console.WriteLine(result);
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray);
FindАverage(myArray);