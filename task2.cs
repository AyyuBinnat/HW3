//Daxil edilen eded yetmisden boyukdurse 70-le ferqin 3 qatini
// Kicikdirse sadece ferqi cap eden proqram

using System;

public class YetmisleMuqayise
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 70)
        {
            Console.WriteLine((70 - number) * 3);
        }
        else
        {
            Console.WriteLine(70 - number);
        }
    }
}