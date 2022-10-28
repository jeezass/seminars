// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввведите цифру, обозначающую день недели:");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("Это выходной день недели");
        }
        else if (dayNumber >= 1 && dayNumber <= 5)
        {
            Console.WriteLine("Это не выходной день недели");
        }
        else
        {
            Console.WriteLine("Это не день недели");
        }
    }
}