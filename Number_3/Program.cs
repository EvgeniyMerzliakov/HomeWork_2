// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7");
int day_of_the_week = Convert.ToInt32(Console.ReadLine());

if ( day_of_the_week >= 6 && day_of_the_week < 8)
{
    Console.WriteLine("да");
}
else if ( day_of_the_week <= 5 && day_of_the_week > 0)
{
    Console.WriteLine("нет");
}
else 
{
    Console.WriteLine("Вы ввели число отличное от условия");
}