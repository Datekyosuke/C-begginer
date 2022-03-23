using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Имя ученика:" + name);
        Console.WriteLine("Введите возраст:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Возраст ученика:" + age);
        Console.WriteLine("Введите балл по русскому языку:");
        int rus = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите балл по математике:");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите балл по информатике:");
        int inf = Convert.ToInt32(Console.ReadLine());
        float sr = (rus + math + inf) / 3;
        Console.WriteLine("Средний балл ученика:" + sr);

    }
}