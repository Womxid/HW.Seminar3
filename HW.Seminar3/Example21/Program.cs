// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("введите координаты двух точек в трех измерениях чтобы найти расстояние между ними. Начните с x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Теперь введите координату x2");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Теперь введите координату y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Теперь введите координату y2");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Теперь введите координату z1");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Теперь введите координату z2");
double z2 = double.Parse(Console.ReadLine());

double distantion = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine($"Расстояние между точками {distantion}");