// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
string[] CreateStringArr(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter the string array element number: " + (i + 1) + " ");
        string? newElem = Convert.ToString(Console.ReadLine());
        arr[i] = newElem;
    }
    return arr;
}

void ShowArr(string[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine();
}

int Count(string[] arr)
{
    int l = arr.Length;
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < l; i++)
    {
        if (arr[i][0] == vowels[0] || arr[i][0] == vowels[1] || arr[i][0] == vowels[2] || arr[i][0] == vowels[3] || arr[i][0] == vowels[4] || arr[i][0] == vowels[5])
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество слов: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] myArr = CreateStringArr(n);

ShowArr(myArr);

Console.WriteLine("Количество слов: " + Count(myArr));

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
string[] CreateStringArr(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter the string array element number: " + (i + 1) + " ");
        string? newElem = Convert.ToString(Console.ReadLine());
        arr[i] = newElem;
    }
    return arr;
}

void PrintArr(string[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine();
}

string[] СoncatenationArr (string[] arrOne, string[] arrTwo) {
    int lengArr = arrOne.Length;
    string[] newArr = new string[lengArr];
    for (int i = 0; i < lengArr; i++)
    {
        newArr[i] = arrOne[i] + arrTwo[i];
    }
    return newArr;
}

Console.Write("Enter the number of words for the two arrays: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] userArrFirst = CreateStringArr(n);

string[] userArrSecond = CreateStringArr(n);

PrintArr(userArrFirst);

PrintArr(userArrSecond);

string[] concatArr = СoncatenationArr(userArrFirst, userArrSecond);

PrintArr(concatArr);