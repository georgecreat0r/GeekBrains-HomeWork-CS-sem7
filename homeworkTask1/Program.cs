/*
Задача 1
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 
M до N. Использовать рекурсию, не использовать циклы.
*/

void Main()
{
    int m = ReadInt("Введите неотрицательное число M: ");
    int n = ReadInt("Введите неотрицательное число N, не меньшее чем M: ");
    if (IsRight(m, n))
    {
        PrintNums(m, n);
    }
    else
    {
        Console.Write("Некорректный ввод. Числа должны быть неотрицательныеми, а M не больше, чем N.");
    }
}

// Обработка некорректного ввода
bool IsRight(int m, int n)
{
    if (m > n || m < 0 || n < 0)
    {
        return false;
    }
    return true;
}

// Рекурсивный метод вывода натуральных чисел от M до N
void PrintNums(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        return;
    }
    Console.Write(m + ", ");
    PrintNums(m + 1, n);
}

// Метод считывания числа от пользователя
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();