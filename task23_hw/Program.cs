// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

Console.WriteLine("Ввведите число:");
int N = int.Parse(Console.ReadLine());

Console.Write("Таблица кубов -> ");
foreach (int num in GetCube(N))
{
    Console.Write($"{num} ");
}

double[] GetCube(int n)
{
    double[] arr = new double[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = Math.Pow(i + 1, 3);
    }
    return arr;
}