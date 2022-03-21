using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
        string aa = Console.ReadLine();
        float a = Convert.ToSingle(aa);
        string bb = Console.ReadLine();
        float b = Convert.ToSingle(bb);
        Console.WriteLine("1 число: " + a);
        Console.WriteLine("2 число: " + b);
        float c = a / b;
        Console.WriteLine(c);
    }
}