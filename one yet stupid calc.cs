using System;

public class MainClass
{
    public static void Main()
    {
        float s = 0;
        Console.WriteLine("Введите число 1:");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введите число 2:");
        float b = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
        char ch = Convert.ToChar(Console.ReadLine());
        switch (ch)
        {
            case '+':
                s = a + b;
                Console.WriteLine("a + b = " + s);
                break;
            case '-':
                s = a - b;
                Console.WriteLine("a - b = " + s);
                break;
            case '*':
                s = a * b;
                Console.WriteLine("a * b = " + s);
                break;
            case '/':
                s = a / b;
                Console.WriteLine("a / b = " + s);
                break;

            default:
                Console.WriteLine("Попробуйте еще раз..");
                break;
        }
    }
}