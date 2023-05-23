//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 2 == 1 )
{
    Console.WriteLine("Number " + numb + " is odd");
}
else
{
    Console.WriteLine("Number " + numb + " is even");
}