// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}
int num = GetValue("Введите число: ");

while (num >= 1000) 
    num /= 10;

System.Console.WriteLine("Третье число: " + num % 10);
