﻿// Задайте одномерный массив, заполненный случайными числами. 
//Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// Console.WriteLine("Hello!");
// string str = "2024";
// int num = Convert.ToInt32(str);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr); 