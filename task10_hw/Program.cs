// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.WriteLine("Ввведите трехзначное число:");
int sNumber = int.Parse(Console.ReadLine());

if ((sNumber >= 100 && sNumber < 1000) || (sNumber <= -100 && sNumber > -1000))
{
    int result = Func(sNumber);
    Console.WriteLine($"Вторая цифра числа: {result}");
}
else
{
    Console.WriteLine("Вы ввели не верное число, число должно быть трехзначным");
}


int Func(int number)
{
    return Math.Abs((number / 10) % 10);
}