// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точек x1, y1, z1, разделяя их клавишей Enter:");
bool parsedX1 = double.TryParse(Console.ReadLine(), out double x1);
bool parsedY1 = double.TryParse(Console.ReadLine(), out double y1);
bool parsedZ1 = double.TryParse(Console.ReadLine(), out double z1);
if (!parsedX1 || !parsedY1 || !parsedZ1)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
Console.WriteLine("Введите координаты точек x2, y2, z2, разделяя их клавишей Enter:");
bool parsedX2 = double.TryParse(Console.ReadLine(), out double x2);
bool parsedY2 = double.TryParse(Console.ReadLine(), out double y2);
bool parsedZ2 = double.TryParse(Console.ReadLine(), out double z2);
if (!parsedX2 || !parsedY2 || !parsedZ2)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
double distance = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками равно {distance} условных тугриков");


double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double dis = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    return dis;
}