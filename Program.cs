
double x = Convert.ToDouble(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine($"y={Math.Sin(x)}");
}
else
{
    Console.WriteLine($"y={Math.Cos(x)}");
}