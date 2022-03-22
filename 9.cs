using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число:");
        float a = Convert.ToSingle(Console.ReadLine());
        if (a%2 == 0)
        {  
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
    }
}