using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
        Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
        Console.WriteLine("Нажмите 3 если хотите выполнить умножение");
        Console.WriteLine("Нажмите 4 если хотите выполнить деление");
        Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");
        int n = Convert.ToInt32(Console.ReadLine());
        float a = 0;
        float b = 0;
        float s = 0;
        switch (n)
        {
            case 1:
                Console.WriteLine("Введите слагаемое 1:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите слагаемое 2:");
                b = Convert.ToSingle(Console.ReadLine());
                s = a + b;
                Console.WriteLine("Сумма чисел = " + s);
                break;
            case 2:
                Console.WriteLine("Введите уменьшаемое:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите вычитаемое:");
                b = Convert.ToSingle(Console.ReadLine());
                s = a - b;
                Console.WriteLine("Разность чисел = " + s);
                break;
            case 3:
                Console.WriteLine("Введите множитель 1:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите множитель 2:");
                b = Convert.ToSingle(Console.ReadLine());
                s = a * b;
                Console.WriteLine("Произведение чисел = " + s);
                break;
            case 4:
                Console.WriteLine("Введите делимое:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите делитель:");
                b = Convert.ToSingle(Console.ReadLine());
                s = a / b;
                Console.WriteLine("Частное чисел = " + s);
                break;
            case 5:
                Console.WriteLine("Введите делимое:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите делитель:");
                b = Convert.ToSingle(Console.ReadLine());
                s = a % b;
                Console.WriteLine("Остаток от деления чисел = " + s);
                break;
            default:
                Console.WriteLine("Значение некорректно");
                break;
        }
    }
}