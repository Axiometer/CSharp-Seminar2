// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int num = GetValue("Введите цифру, обозначающую день недели: ");

if (num > 0 && num < 6)
    System.Console.WriteLine("Этот день рабочий");
else if (num == 6 || num == 7)
    System.Console.WriteLine("Этот день выходной");
else
    System.Console.WriteLine("Входные данные неверны");
