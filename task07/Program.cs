// Напишите программу, которая принимает на вход трехзначное число
// а на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastdigit = number % 10;
    Console.WriteLine($"Последняя цифра числа => {lastdigit}");
}
else System.Console.WriteLine("Число не трехзначное!");
