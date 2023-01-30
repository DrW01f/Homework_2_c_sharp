// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите любое число");
int count = int.Parse(Console.ReadLine()!);
if (count > 99)
{
    int result = count % 1000;
    result = result / 100;
    Console.WriteLine($"Третья цифра {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
