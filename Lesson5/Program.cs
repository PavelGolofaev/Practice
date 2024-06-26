﻿// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы
// на их квадраты.
// Пример


// 2 3 4 3
// 4 3 4 1

// 2 9 5 4
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //
    int[,] matrix = new int[rows, columns]; // 3 x 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = 4
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        //Console.WriteLine(" |");
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);