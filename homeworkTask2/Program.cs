/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/


void Main()
{
    int m = ReadInt("Введите неотрицательное число M: ");
    int n = ReadInt("Введите неотрицательное число N: ");
    if (IsRight(m, n))
    {
        Console.Write(FunAk(m, n));
    }
    else
    {
        Console.Write("Некорректынй ввод. Числа должны быть неотрицательные.");
    }

}

// Обработка некорректного ввода
bool IsRight(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return false;
    }
    return true;
}

// Функция Аккермана
int FunAk(int m, int n)
{
    int funAk;
    if (m == 0)
    {
        funAk = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        funAk = FunAk(m - 1, 1);
    }
    else
    {
        funAk = FunAk(m - 1, FunAk(m, n - 1));
    }

    return funAk;
}

// Метод считывания числа от пользователя
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();