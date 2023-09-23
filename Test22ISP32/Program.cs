//Напишите метод, который принимает две пары чисел: первая – координаты (Х и У) точки А, вторая - координаты (Х и У) точки В. Метод возвращает длину отрезка АВ.
Console.Write("Введите координату x окружности:");
double x=double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y окружности:");
double y = double.Parse(Console.ReadLine()!);
Console.Write("Введите радиус окружности:");
double r = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату x точки:");
double px = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки:");
double py = double.Parse(Console.ReadLine()!);
MyClass myClass = new MyClass();
Console.WriteLine(myClass.ToCircle(x,y,r,px,py));
public class MyClass
{
    public bool ToCircle(double x,double y,double r,double px,double py)
    {
        if ((px - x) * (px - x) + (py - y) * (py - y) <= r * r) return true;
        return false;
    }
    public double Sum(double x,double y)
    {
        return x + y;
    }
}
