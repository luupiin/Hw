// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

  int i = 1;
bool not = true;

Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even numbers from 1 to " + num);
    while (i <= num)
{
     if (i % 2 != 1)
       {
        Console.Write(i + ", ");
        not = false;
        }
    i++;
}

    if (not)
{
    Console.WriteLine("There are no even numbers in this range.");
}