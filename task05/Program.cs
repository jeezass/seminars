// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все целые числа от {-number} до {number}: ");

int counter = -number;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}