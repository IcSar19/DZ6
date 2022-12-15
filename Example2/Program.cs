Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double Intersection(double k1, double k2, double b1, double b2)
{
    double x = 0;
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают и имеют бесконечное количество точек пересечения.");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
    else 
    {
        x = (b2-b1)/(k1-k2);
    }
    return x;
}
if (Intersection(k1,k2,b1,b2) != 0)
{
    Console.WriteLine($"Прямые имеют одну точку пересечения ({Intersection(k1,k2,b1,b2)};{k1*Intersection(k1,k2,b1,b2)+b1}).");
}