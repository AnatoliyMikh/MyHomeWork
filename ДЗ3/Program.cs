/*
//  Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Polindrom(int n1)
{
    if(n1/10000 == n1%10)
    {
        if (n1/1000%10 == n1%100/10);
        return true;
    }
    else
        return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(Polindrom(num));
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Pifagor3D(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double rasstoyanie = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return rasstoyanie;
} 

Console.WriteLine("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние равно:" + Pifagor3D(x1, x2, y1, y2, z1, z2));



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void StepenKub(int num)
{
    int i = 1;
    int kub = 1;
    while (i <= num)
    {
        kub = i * i * i;
        Console.WriteLine(kub + " ");
        i++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

StepenKub(number); */