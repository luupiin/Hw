Console.WriteLine("enter a value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a number k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a number k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Two straight lines will intersect at a point with X coordinates: {x}, Y: {y}");
