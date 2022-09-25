//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//√ (x2-x1)² + (y2-y1)² + (z2-z1)²

Console.Clear();

Console.Write("Введите координату Х для точки А ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки А ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z для точки А ");
double za = double.Parse(Console.ReadLine());

Console.Write("Введите координату Х для точки B ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки B ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z для точки B ");
double zb = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) 
+ Math.Pow(za - zb, 2));
//d = Math.Round(d, 2);
//console.Write($"Длина отрезка = {d:f2});
Console.Write(d.ToString("#.00"));
