// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowNum(int numOne, int numTwo)
// {
//     int result = 1;
//     int i = 0;
//     while(i<numTwo)
//     {
//         result = result * numOne;
//         i++;
//     }
//     return result;
// }
// Console.Write("Введите первое число: ");
// int numOne = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int numTwo = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// int i = 0;
// while(i<numTwo)
// {
//     result = result * numOne;
//     i++;
// }
// System.Console.WriteLine(result);

// System.Console.WriteLine(PowNum(numOne,numTwo));


// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumCount(string num)
{
    int result = 0;
    for(int i = 0; i < num.Length; i++)
    {
        int numSecond;
        if(int.TryParse(num[i].ToString(), out numSecond))
        {
            result += numSecond;
        }
        else
        {
            Console.WriteLine("Ошибка! Введите число!");
            return 0;
        }
    }
     return result;
}
Console.Write("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine(NumCount(num));

