double[] arr = new double[6];

Console.WriteLine("Give the value of a");
arr[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of b");
arr[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give the value of c");
arr[2] = Convert.ToDouble(Console.ReadLine());

void solver()
{
    double D = Math.Pow(arr[1], 2) - 4 * arr[0] * arr[2];
    if (D >= 0 && arr[0] != 0)
    {
        arr[3] = (-1 * arr[1] + Math.Pow(D, 0.5)) / (2 * arr[0]);
        arr[4] = (-1 * arr[1] - Math.Pow(D, 0.5)) / (2 * arr[0]);
        arr[5] = 1;
    }
    else if (arr[0] == 0 && arr[1] == 0)
    {
        Console.WriteLine("There are no x1 and x2");
    }
    else if (arr[0] == 0)
    {
        arr[3] = -1 * arr[2] / arr[1];
        arr[5] = 2;
    }
    else
    {
        Console.WriteLine("Discriminant is smaller than 0");
    }
}

solver();
if (arr[5] == 1)
{
    Console.WriteLine($"x1 is {arr[3]} and x2 is {arr[4]}");
}
else if (arr[5] == 2)
{
    Console.WriteLine($"There is only one x and it is {arr[3]}");
}
