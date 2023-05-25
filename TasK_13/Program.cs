// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// https://blablacode.ru/c_code/1413

Console.WriteLine("Введите любое целое число");
int number = int.Parse(Console.ReadLine());
while (number > 999)
{
    number = number / 10;
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number <= 999)
{
int TherdDigit = number % 10;
Console.WriteLine(TherdDigit);
}

