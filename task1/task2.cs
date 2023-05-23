// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int number_b = Convert.ToInt32(Console.ReadLine());

if ( number_a > number_b )
{
         Console.WriteLine(" First number " + number_a + " more than " + number_b);
}
else 
{
        Console.WriteLine(" Second number " + number_b + " more than " + number_a);
}

