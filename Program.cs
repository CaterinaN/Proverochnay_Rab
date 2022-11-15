
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;
Clear();

string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

int MAX_WORD_LENGTH = 3;

string[] GetShortWordsArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MAX_WORD_LENGTH)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}


void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        WriteLine("[]");
    }
    else
    {
        Array.ForEach(array, (str) => Write($"[{str}] "));
        WriteLine();
    }
}

void PrintTask(string[] array)
{
    WriteLine("Первоначальный Массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    WriteLine($"новый массив из строк,длина которых меньше, либо равна {MAX_WORD_LENGTH} символам :");
    PrintArray(shortArray);
    WriteLine();
}
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);
