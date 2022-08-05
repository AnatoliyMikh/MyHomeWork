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

void Ordering(int[,] arr)
{
    int buf = 0;
    
    for(int i=0; i < arr.GetLength(0); i++)
    {   
        for(int j=0; j < arr.GetLength(1); j++)
        {
            for(int n=j+1; n < arr.GetLength(1); n++)
            {
                if(j != arr.GetLength(1)-1)
                    if(arr[i,j] <= arr[i,n])
                        {
                            buf = arr[i,n];
                            arr[i,n] = arr[i,j];
                            arr[i,j] = buf;
                        }
            }       
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();    
    }        
      
    
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandomArray(m,n);
ShowArray(myArray); 
Console.Write("Отсортированный массив: ");
Ordering(myArray);


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

int[,] Spiral(int n, int b)
{
    int[,] result = new int[n, b];
    int columns = result.GetLength(1);
    int rows = result.GetLength(0);
    int value = 1;
    for (int i = 0; value <= n * b; i++)
    {
        if (value <= n * b)
        {
            for (int j = i; j < columns - i; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int k = i + 1; k < rows - i; k++)
            {
                result[k, columns - (1 + i)] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int m = columns - (2 + i); m >= i; m--)
            {
                result[rows - (1 + i), m] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int s = rows - (2 + i); s >= i + 1; s--)
            {
                result[s, i] = value;
                value++;
            }
        }
    }
    return result;
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 4;

int columns = 4;


int[,] myArr = Spiral(rows, columns);

ShowArray(myArr); 
