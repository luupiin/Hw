// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Enter a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// calling the Ackerman function
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// Ackerman function
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}