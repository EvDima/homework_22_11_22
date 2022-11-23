// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double a1 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double c1 = double.Parse(Console.ReadLine());
double a2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double c2 = double.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(c2 - c1, 2));
Console.WriteLine(s);