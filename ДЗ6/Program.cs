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
