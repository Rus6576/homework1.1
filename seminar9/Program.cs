// Задача 63. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N=5 -> "1, 2, 3, 4, 5"
// N=6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int startNum=1;

// Console.WriteLine(PrintNumbers(startNum,num));

// string PrintNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//         return (start + " " + PrintNumbers(start+1, end));
// }


// Задача 65. Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N;
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Console.WriteLine("Введите начальное число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите конечное число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 < num2)
// {
//     Console.WriteLine(PrintNumbers (num1,num2));
// }
// else
// {
//     Console.WriteLine("Ввод некоректный!");
// }

// string PrintNumbers(int start, int end);
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//         return (start + " " + PrintNumbers(start+1, end));
// }