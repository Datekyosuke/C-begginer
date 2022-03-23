using System;

public class MainClass
{
    public static void Main()
    {
        float s ,a , b = 0;
        for(int i = 1; i < 2; )
        { 
            Console.WriteLine("Введите число 1:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            b = Convert.ToSingle(Console.ReadLine());
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
            Console.WriteLine("Хотите продолжить выполнение программы?");
            Console.WriteLine("ДА - 1. НЕТ - 2.");
            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}