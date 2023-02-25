// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

try
{
    Console.WriteLine("Enter x-axis coordinate of first point");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter y-axis coordinate of first point");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter z-axis coordinate of first point");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter x-axis coordinate of second point");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter y-axis coordinate of second point");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter z-axis coordinate of second point");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine($"The distance beetween the points is {distance}");
}
catch
{
    Console.WriteLine("You have entered incorrect data, please restart the application and enter a real numbers as coordinates");
}