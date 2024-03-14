/*Console.WriteLine("Give the value of a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of c");
double c = Convert.ToDouble(Console.ReadLine());

double x1 = 0, x2 = 0, bl = 0;

void solver(ref double x1, ref double x2, double a, double b, double c)
{
    double D = Math.Pow(b, 2) - 4 * a * c;
    if(D >= 0 && a != 0)
    {
        x1 = (-1 * b + Math.Pow(D, 0.5)) / (2 * a);
        x2 = (-1 * b - Math.Pow(D, 0.5)) / (2 * a);
        bl = 1;
    }
    else if(a == 0 && b == 0)
    {
        Console.WriteLine("There are no x1 and x2");
    }
    else if (a == 0)
    {
        x1 = -1 * c / b;
        bl = 2;
    }
    else
    {
        Console.WriteLine("Discriminant is smaller than 0");
    }
}

solver(ref x1, ref x2, a, b, c);
if (bl == 1)
{
    Console.WriteLine($"x1 is {x1} and x2 is {x2}");
}
else if (bl == 2)
{
    Console.WriteLine($"There is only one x and it is {x1}");
}*/