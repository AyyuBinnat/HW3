// Daxil edilen 2 eded arasindaki tek ededleri daxil edin

using System;

public class TekEdedler
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ilk ededi daxil edin: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin: ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i < y; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}