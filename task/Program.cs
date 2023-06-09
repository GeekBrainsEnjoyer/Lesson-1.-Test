﻿// Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна
//3 символам. Первоначальный массив можно ввести с клавиатуры, либо
//задать на старте выполнения алгоритма. При решении не 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        System.Console.Write($"{array[i]} ");

    System.Console.WriteLine();
}

string[] FillArray()
{
    string[] userInputArray = new string[99];

    for (int i = 0; i < userInputArray.Length; i++)
    {
        string input = Console.ReadLine()!;
        if (input == "") return userInputArray;
        else userInputArray[i] = input;
    }
    return userInputArray;
}

string[] CheckStringLenght(string[] array, int notEmptyString)
{
    string[] newStringArray = new string[notEmptyString];

    for (int i = 0; i < newStringArray.Length; i++)
    {
        if (array[i].Length <= 3)
            newStringArray[i] = array[i];
    }

    return newStringArray;
}

int CountIsNotEmptyString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != null)
            count++;

    return count;
}

System.Console.WriteLine("Введите элементы массива");
System.Console.WriteLine("Чтобы закончить, нажмите 2 раза Enter");
string[] array = FillArray();
int count = CountIsNotEmptyString(array);
string[] newArray = CheckStringLenght(array, count);
System.Console.WriteLine("Массив введенных элементов: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Массив элементов, длина которых меньше либо равна 3 символам: ");
PrintArray(newArray);
System.Console.WriteLine();
