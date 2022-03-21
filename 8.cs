using System;

public class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года\nОтветь на данный факт true или false");
        string stroka = Console.RideLine();
        bool ans = Convert.ToBoolean(stroka);
        Console.WriteLine("Oтвет: " + ans);
    }
}