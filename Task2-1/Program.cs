// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}
int num = GetValue("Введите трехначное число: ");
if (!(num > 999 || num < 100))
{
    int second = num/10%10;
    System.Console.WriteLine("Средняя цифра равна " + second);
}
else 
    System.Console.WriteLine("Входные данные неверны");