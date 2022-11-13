// Daxil edilen iki ededin arasindaki ededleri cap eden proqram

using System;

public class AraliqdakiEdedler
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ilk ededi daxil edin");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin");
        int number2 = Convert.ToInt32(Console.ReadLine());

        for (int i = number1; i <= number2; i++)
        {
            Console.WriteLine(i);
        }
    }
}