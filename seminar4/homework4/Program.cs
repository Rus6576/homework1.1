// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine);

System.Console.WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine);
int result = 0;
int i = 1;
while(i<numTwo)
{
    result = result * numOne;
    i++;
}
System.Console.WriteLine(result);
