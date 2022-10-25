// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число: ");
bool parsedNum = int.TryParse(Console.ReadLine(), out int num);
TableOfCubes(num);

void TableOfCubes(int x)
{
    for (int i = 1; i <= x; i++)
    {
        int y = i * i * i;
        Console.Write($"{y} ");
    }
}