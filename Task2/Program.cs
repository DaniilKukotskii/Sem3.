double ABcoord(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    return(result);
}

Console.WriteLine("Введите координаты точки А(x, y,z)");
int x11 = Convert.ToInt32(Console.ReadLine());
int y11 = Convert.ToInt32(Console.ReadLine());
int z11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B(x, y,z)");
int x22 = Convert.ToInt32(Console.ReadLine());
int y22 = Convert.ToInt32(Console.ReadLine());
int z22 = Convert.ToInt32(Console.ReadLine());

double distance = ABcoord(x11, y11, z11, x22, y22, z22);
Console.Write($"Distance = {distance:f3}");