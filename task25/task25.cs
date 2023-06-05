// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a ;

for (int i = 1; i < b; i++)
{

step = step * a ;

}

Console.WriteLine("A to the power of B is equal to:" + step);