// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(0, 50);
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

int[,] Ordering(int[,] arr)
{
    int buf = 0;

    for(int i=0; i < arr.GetLength(0); i++)
    {   
        for(int j=0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] < arr[i,j+1])
            {
                buf = arr[i,j+1];
                arr[i,j+1] = arr[i,j];
                arr[i,j] = buf;
            }
            
        }
        Console.WriteLine();
    }
    return Ordering(arr);
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray); 

Console.WriteLine("Полученный массив: ");
Console.WriteLine(Ordering(myArray));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.




// Задача 62. Заполните спирально массив 4 на 4.
