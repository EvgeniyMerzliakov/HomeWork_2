// Задача необязательная 2: по желанию идет за 2 необязательных
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает 
// количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, 
// чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 100 человек.


Console.WriteLine("Введите число от 1 до 100");
int number_man_1 = Convert.ToInt32(Console.ReadLine());
int number_man = number_man_1;
int number = number_man_1;
int i = 0;


while (number_man_1 > 0)
{
    number_man_1 = number_man_1 / 10;
    i++;
}

if (number_man < 1 || number_man > 100)
{
     Console.WriteLine("Задано неверное число");
}

else if (number_man > 9 && number_man < 21 || number_man == 30 || number_man == 40 || number_man == 50 || number_man == 60 || number_man == 70 || number_man == 80 || number_man == 90 || number_man == 100)
{
    Console.WriteLine(number + " программистов");
}

else
{
    int count = 1;
    while (i >= count)
    {   
        if (i == count && number_man >= 1 && number_man <= 10)
        {
            if (number_man == 1) Console.WriteLine(number + " программист");
            else if (number_man >= 2 && number_man <= 4) Console.WriteLine(number + " программиста");
            else if (number_man == 0 || number_man >= 5 && number_man <= 9) Console.WriteLine(number + " программистов");
        }
        else
        {
            number_man = number_man % 10;
        }
    count++;
    }
}


//if (number_man >= 1 && number_man <= 10 || number_man >= 21 && number_man <= 100)

// if (number_man > 10 && number_man < 21)
// {
//     Console.WriteLine("программистов");
// }
// else if (number_man < 1 && number_man > 100)
// {
//     Console.WriteLine("Задано неверное число");
// }
// else
// {
//     while (i < )
// }

 // if (number_man == 1) Console.Write("программист");
    // else if (number_man >= 2 && number_man <= 4) Console.Write("программиста");
    // else if (number_man == 0 || number_man >= 5 && number_man <= 9) Console.Write("программистов");