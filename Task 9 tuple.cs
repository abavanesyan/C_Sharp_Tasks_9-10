Console.WriteLine("Give the value of a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of c");
double c = Convert.ToDouble(Console.ReadLine());

var t = (a, b, c);

double x1 = 0, x2 = 0, bl = 0;

void solver()
{
    double D = Math.Pow(t.b, 2) - 4 * t.a * t.c;
    if (D >= 0 && t.a != 0)
    {
        x1 = (-1 * t.b + Math.Pow(D, 0.5)) / (2 * t.a);
        x2 = (-1 * t.b - Math.Pow(D, 0.5)) / (2 * t.a);
        bl = 1;
    }
    else if (t.a == 0 && t.b == 0)
    {
        Console.WriteLine("There are no x1 and x2");
    }
    else if (t.a == 0)
    {
        x1 = -1 * t.c / t.b;
        bl = 2;
    }
    else
    {
        Console.WriteLine("Discriminant is smaller than 0");
    }
}

solver();
if (bl == 1)
{
    Console.WriteLine($"x1 is {x1} and x2 is {x2}");
}
else if (bl == 2)
{
    Console.WriteLine($"There is only one x and it is {x1}");
}
