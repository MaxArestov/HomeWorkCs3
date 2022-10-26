// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число:");
bool parsedNumber = int.TryParse(Console.ReadLine(), out int digit);
if (!parsedNumber)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
int quantity = HowManyDigits(digit);
Console.WriteLine(quantity);
int[] arrayDigits = IntToArray(digit, quantity);
int[] reverseArrays = new int[quantity];
Array.Copy(arrayDigits, reverseArrays, quantity);
ReverseArray(reverseArrays);
PrintArray(arrayDigits);
PrintArray(reverseArrays);
CompareArrays(arrayDigits, reverseArrays);









void CompareArrays(int[] firstArray, int[] secondArray)
{
    int length = firstArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (firstArray[i] != secondArray[i])
        {
        Console.WriteLine("False");
        return;
        }
        
        
    }
    Console.WriteLine("True.");
}

int[] IntToArray(int number, int quan)
{
    int i = 0;
    int[] array = new int[quan];
    for (i = 0; number != 0; i++)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}

int[] ReverseArray(int[] masses)
{
    int support = 0;
    int j = 0;
    int[] array2 = masses;
    for (j = 0; j < (masses.Length / 2); j++)
    {
        support = array2[j];
        array2[j] = array2[masses.Length - (j+1)];
        array2[masses.Length - (j+1)] = support;
    }
    return array2;
}

void PrintArray(int[] mass)
{
    int line = mass.Length;
    int count = 0;
    Console.WriteLine("Элементы массива: ");
    while (count < line)
    {
        Console.Write($"{mass[count]} ");
        count++;
    }
}
int HowManyDigits(int figure)
{
    int i = 0;
    for (i = 0; figure != 0; i++)
    {
        figure /= 10;
    }
    return i;
}