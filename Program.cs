/* Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"] -> ["-2]
["Russia","Denmark","Kazan"] -> []
*/
// Вариант 1 - массив задан на старте выполнения алгоритма
/*
string[] array = {"Russia", "Denmark", "Kazan"};
Console.WriteLine($"Первоначальный массив [{String.Join(", ", array)}]");
Console.WriteLine($"Новый массив [{String.Join(", ", CreateArray(array))}]");

string[] CreateArray (string[] arr)
{
    int len = new Random().Next(0,4);
    string[] newArr = new string[len];
    for (int i = 0; i < len; i++)
    {
        int j = new Random().Next(0,len);
        newArr[i] = arr[j];
    }
    return newArr;
}
*/
// Вариант 2 - массив вводится с клавиатуры
Console.Write("Введите длину первоначального массива: ");
int N = int.Parse(Console.ReadLine()!);
string[] array = new string[N];
FillArray(array);
Console.WriteLine($"Первоначальный массив [{String.Join(", ", array)}]");
Console.WriteLine($"Новый массив [{String.Join(", ", CreateArray(array))}]");

void FillArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й символ/набор символов для массива: ");
        string S = Console.ReadLine()!;
        arr[i] = S;
    }
}

string[] CreateArray (string[] arr)
{
    int len = new Random().Next(0,4);
    string[] newArr = new string[len];
    for (int i = 0; i < len; i++)
    {
        int j = new Random().Next(0,len);
        newArr[i] = arr[j];
    }
    return newArr;
}
