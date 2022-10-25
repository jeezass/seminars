// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ввведите число:");
int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine("Способы решения задачи: \n № 1 - поиск по строке, \n № 2 - поиск с помощью математической функции, \n № 3 - поиск с помощью цикла. \n Ввведите номер способа решения задачи:");
int N = int.Parse(Console.ReadLine());

switch (N)
{
    case 1:
        StringSearch(number);
        break;

    case 2:
        SearchFunction(number);
        break;

    case 3:
        SearchWithALoop(number);
        break;

    default:
        Console.WriteLine("Такого способа решения задачи нет"); ;
        break;
}

//нахождение числа в строке
void StringSearch(int number)
{
    string numberS = Convert.ToString(number);

    if (numberS.Length > 2)
    {
        string result = Convert.ToString(numberS[2]);
        Console.WriteLine($"Третья цифра = {result}");
    }
    else
    {
        Console.WriteLine("Tретьей цифры нет");
    }
}

//нахождение числа с помощью функции
void SearchFunction(int number)
{
    int k = (int)Math.Log10(number) - 2;
    Console.WriteLine(k < 0 ? "Tретьей цифры нет" : $"Третья цифра = {SFunc(number, k)}");
}

int SFunc(int n, int k)
{
    return n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k);
}

//нахождение числа с помощью цикла
void SearchWithALoop(int number)
{
    if (number >= 1000)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третья цифра = {number % 10}");
    }
    else if (number >= 100 && number < 1000)
    {
        Console.WriteLine($"Третья цифра = {number % 10}");
    }
    else
        Console.WriteLine("Tретьей цифры нет");}    