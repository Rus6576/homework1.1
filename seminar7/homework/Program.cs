// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// System.Console.WriteLine("Введите количество строк"); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
 
// System.Console.WriteLine("Введите количество столбцов"); 
// int colomns = Convert.ToInt32(Console.ReadLine()); 
 
// int[,] matrix = new int[rows,colomns]; 
 
// for (int i = 0; i < matrix.GetLength(0); i++) 
// { 
//     for (int j = 0; j < matrix.GetLength(1); j++) 
//     { 
//         matrix[i,j] = new Random().Next(0,10); 
//         Console.Write(matrix[i,j]+" "); 
//     } 
//     System.Console.WriteLine(); 
// } 
 
// int sum = 0; 
// double average = 0; 
 
// for (int j = 0; j < matrix.GetLength(1); j++) 
// { 
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     { 
//         sum+=matrix[i,j]; 
//     } 
//     average = (double)sum / rows; 
//     System.Console.WriteLine($"Среднее арифметическое столбца {j} равно {average}" ); 
//     sum = 0; 
// }


// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int colomns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[rows,colomns]; 
 
for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
    for (int j = 0; j < matrix.GetLength(1); j++) 
    { 
        matrix[i,j] = new Random().NextDouble()*10; 
        Console.Write(matrix[i,j]+" "); 
    } 
    System.Console.WriteLine(); 
}
