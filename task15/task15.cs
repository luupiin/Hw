//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNumber = ReadInt("Enter a number from 1 to 7: ");
Console.WriteLine(WORKHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WORKHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("It's a day off, but we need to study");
        }
        else
        {
            Console.Write("Working day");
        }
    }
    else
    {
        Console.Write("There is no such day in the week");
    }
    return ".";
}  
