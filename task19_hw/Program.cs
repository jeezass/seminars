Console.WriteLine("Ввведите число:");
int N = int.Parse(Console.ReadLine());
if (N >= 10000 && N < 100000)
{
    Palindrome(N);
}
else
{
    Console.WriteLine("Вы ввели не верное число, число должно быть пятизначным");
}

void Palindrome(int number)
{
    if (((number / 10000) == (number % 10)) && ((number / 1000 % 10) == (number % 100 / 10)))
    {
        Console.WriteLine($"Число {number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндромом");
    }
}
