// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int startNum = 1;

// Console.WriteLine(PrintNumbers(num ,startNum));

// string PrintNumbers(int end, int start)
// {
//     if(end == start)
//     {
//         return start.ToString();
//     }
//         return (end + " " + PrintNumbers(end - 1,start));
// }


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное число: ");
int num2 = int.Parse(Console.ReadLine());

string PrintNumbers(int num1 , int num2)
    {
    if(num1 == num2)
    {
        return num1.ToString();
    }
        return num1 + " " + PrintNumbers(num1+1, num2);
    }

if (num1 > num2)
{
    Console.WriteLine("Первое число должно быть меньше второго!");
}
else
{
    Console.WriteLine("Массив состоит из чисел" +PrintNumbers(num1,num2));

    int sum = 0;
    while (num1<=num2)
    {
        sum+=num1;
        num1++;
    }
    Console.WriteLine($"Сумма чисел массиваравна {sum}");
}

