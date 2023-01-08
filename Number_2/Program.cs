// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
int x1 = x;

while (x > 0)
{
    x = x / 10; 
    i++; 
}

if (i >= 3)
{
    int count = 3;
    while (i >= count)
    {
        if (i == count)
        {
            x1 = x1 % 10;
        }
        else 
        {
            x1 = x1 / 10;
        }
        count++;
    }
    Console.WriteLine(x1);
}
else
{
    Console.WriteLine("Третьей цифры не найдено");
}
