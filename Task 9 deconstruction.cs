Console.WriteLine("Give the value of a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of c");
double c = Convert.ToDouble(Console.ReadLine());

Solver dec = new Solver(a, b, c);
if (dec.bl == 0)
{
    Console.WriteLine("Discriminant is smaller than 0");
}
else if (dec.bl == 1)
{
    Console.WriteLine($"x1 is {dec.x1} and x2 is {dec.x2}");
}
else if (dec.bl == 2)
{
    Console.WriteLine($"There is only one x and it is {dec.x1}");
}
else
{
    Console.WriteLine("There are no x1 and x2");
}

class Solver
{
    public double x1, x2, bl = 0, D;
    public Solver(double a, double b, double c)
    {
        D = Math.Pow(b, 2) - 4 * a * c;
        if (D >= 0 && a != 0)
        {
            x1 = (-1 * b + Math.Pow(D, 0.5)) / (2 * a);
            x2 = (-1 * b - Math.Pow(D, 0.5)) / (2 * a);
            bl = 1;
        }
        else if (a == 0 && b == 0)
        {
            bl = 3;
        }
        else if (a == 0)
        {
            x1 = -1 * c / b;
            bl = 2;
        }
    }
}