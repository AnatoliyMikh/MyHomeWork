// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
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
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindString(int[,] massive)
{   
    int[] sum = new int[5];
    int n = 0;

    for(int i=0; i < massive.GetLength(0); i++)
    {
        for(int j=0; j < massive.GetLength(1); j++)
        {
            sum[n] += massive[i,j];
        }
        n++;
    }
    
    // int min = sum[0];
     
    if(sum[0] < sum[1] && sum[0] < sum[2] && sum[0] < sum[3] && sum[0] < sum[4])
    {
        Console.WriteLine("Номер строки с наименьшей суммой 1");
    }
    else 
        if(sum[1] < sum[0] && sum[1] < sum[2] && sum[1] < sum[3] && sum[1] < sum[4])
    {
        Console.WriteLine("Номер строки с наименьшей суммой 2");
    }
    else 
        if(sum[2] < sum[0] && sum[2] < sum[1] && sum[2] < sum[3] && sum[2] < sum[4])
    {
        Console.WriteLine("Номер строки с наименьшей суммой 3");
    }
    else 
        if(sum[3] < sum[0] && sum[3] < sum[1] && sum[3] < sum[2] && sum[3] < sum[4])
    {
        Console.WriteLine("Номер строки с наименьшей суммой 4");
    }
    else
        Console.WriteLine("Номер строки с наименьшей суммой 5");

}   


int m = 5;

int n = 4;

int[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray);

FindString(myArray);



// Задача 62. Заполните спирально массив 4 на 4.
