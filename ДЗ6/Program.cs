// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double[] CreateNewArray(int n1)
{
   double[] arr = new double[n1];

    for (int i = 0; i < arr.Length; i++) 
    {
        Console.WriteLine("Введите элемент массива ");
        arr [i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

double FindElement(double[] array)
{
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

Console.Write("Введите количество элементов: ");
int n1 = Convert.ToInt32(Console.ReadLine());

double[] array = CreateNewArray(n1);
Console.WriteLine("Количество элементов равно: " + FindElement(array));


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double FindKoord1(double k1, double b1, double k2, double b2)
{
    double x = 0;

    x = (b1-b2)/(k2-k1);    

    return x;
}

double FindKoord2(double k1, double b1, double k2, double b2)
{
    double y = 0;

    y = (k2*(b1-b2))/(k2-k1);    

    return y;
}

Console.WriteLine("Введите k1: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double m1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double m2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Пересечение прямых в координатах " + (FindKoord1(n1, m1, n2, m2) + ";" +FindKoord2(n1, m1, n2, m2)));