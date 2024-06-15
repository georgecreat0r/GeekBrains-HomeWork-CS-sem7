/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/

void Main()
{
    int arSize = ReadInt("Укажите размер массива: ");
    int[] array = CreateArray(arSize);
    Console.WriteLine(string.Join(" ", array)); // Печать изначального массива
    ReversePrintArray(array);
}

// Рекурсивный метод вывода элементов массива с конца
void ReversePrintArray(int[] array)
{
    if (array.Length == 0)
    {
        return;
    }
    Console.Write(array[array.Length - 1] + " ");
    ReversePrintArray(array[..(array.Length - 1)]); // Использование диапазона для укорачивания с конца
}

// Метод создания массива
int[] CreateArray(int size)
{
    int[] array = new int[size];
    FillArray(array);
    return array;
}

// Рекурсивный метод заполнения массива числами от нуля до десяти
void FillArray(int[] array, int i = 0)
{
    if (i == array.Length)
    {
        return;
    }
    Random rnd = new Random();
    array[i] = rnd.Next(0, 11);
    FillArray(array, i + 1);
}

// Метод считывания числа от пользователя
int ReadInt(string msg)
{
    Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();