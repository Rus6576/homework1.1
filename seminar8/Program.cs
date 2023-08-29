﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторую размерность массива");
// int coloms = Convert.ToInt32(Console.ReadLine());

// int[,] matrix= new int[rows,coloms];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// for(int j =0 ; j < matrix.GetLength(1); j++)
// {
//     int changer=matrix.GetLength(0)-1;
//     int temp= matrix[0,j];
//     matrix[0,j]=matrix[changer,j];
//     matrix[changer,j]= temp;
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }


// Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы. В случае, если это
//   невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Первую размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix= new int[rows,rows];

int[,] matrix2= new int[rows,rows];

void CreateArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            matrix[i,j]= new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j <  array.GetLength(1); j++)
            {
                Console.Write(array[i,j]+ " ");
            }
            Console.WriteLine();
        }
}

void ChangeArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            matrix2[j,i]= matrix[i,j];
        }
    }
}

CreateArray();
PrintArray(matrix);
Console.WriteLine();
ChangeArray();
PrintArray(matrix2);