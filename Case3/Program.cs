// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число: ");
bool parsedNum = int.TryParse(Console.ReadLine(), out int num);
if (!parsedNum)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
int[] cubesOfDigits = new int[num + 1];
TableOfCubes(num, cubesOfDigits);
PrintArray(cubesOfDigits);


int[] TableOfCubes(int x, int[] array)
{
        for (int i = 1; i <= x; i++)
    {
        array[i] = i * i * i;
    }
    return array;
}
void PrintArray(int[] mass)
{
    int line = mass.Length;
    int count = 1;
    Console.WriteLine("Кубы чисел до введенного Вами числа: ");
    while (count < line)
    {
        Console.Write($"{mass[count]} ");
        count++;
    }
}