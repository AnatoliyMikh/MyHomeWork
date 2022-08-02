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
            Console.Write(array[i,j] + " ");
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


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
