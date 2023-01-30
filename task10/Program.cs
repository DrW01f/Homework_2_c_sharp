// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int key = 0; //флаг на выход из цикла вместо break
while (key != 1)
{
    Console.WriteLine("Введите трехзначное число");
    int count = int.Parse(Console.ReadLine()!);

    if (count > 99 && count < 1000)
    //Проверка на трехзначное число
    {
        Console.Clear();
        Console.WriteLine("Что-то пошло не так и оно пропало =(");
        Console.WriteLine("Если помните его, то введите повторно или введите новое число");
        int fake_count = int.Parse(Console.ReadLine()!);
        int result = count % 100;
        result = result / 10;
        Console.WriteLine($"Шучу, вы ввели {count}, вторая цифра {result}");
        key = 1;
    }
    else
    {
         Console.WriteLine("Это не трехзначное число. Попробуйте снова.");
    }
}
