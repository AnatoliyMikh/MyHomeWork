//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int n1)
{
    int receivednumber = n1%100;       
    int result = receivednumber/10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
 
int res = SecondDigit(num);
Console.WriteLine("Вторая цифра: " + res);*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdDigit(int num1)
{
    /*int num2 = num1/100;

    if(num2 <= 99)
        {
            Console.WriteLine("Введите число:");
        }
    else
        {
        int number = num2 % 10;

        Console.WriteLine("Третья цифра " + number);
        }*/
    if (num1 <= 99)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {
        do
        {
            num1 = num1/10;
        }   
        while(num1 > 100 && num1 <= 999);
        if (num1 < 100)
        {
            Console.WriteLine("loshara");
        }

        int num2 = num1%10;
        Console.WriteLine("Третья цифра " + num2);
    }
}

Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
 
ThirdDigit(chislo);

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void WeekEnd(int d1)
{
    if(d1 ==6 && d1 == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
        Console.WriteLine("Будний день");
}
Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
 
WeekEnd(day);*/