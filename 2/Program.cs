// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
Console.WriteLine("Введенное число = " + n);
if (n > 100)
{
    if (n >= 1000)
    {
        if (n >= 100000)
        {
        Console.WriteLine($"Введенное число {n} не может быть больше или равно 100000");
        }
        else
        {
         a = n / 100;
        int res1 = a % 10;
        Console.WriteLine($"Третья цифра числа 1 {n} - {res1}");
        }
    }
    else
    {
    int res = n % 10;
    Console.WriteLine($"Третья цифра числа {n} - {res}");
    }
}
else
{
    Console.WriteLine($"В числе {n} третьей цифры нет");
}