using System;

class Program
{
    static void Main()
    {
        int[] num = { 1, 2, 3, 4, 5 };
        Array.Reverse(num);
        int[] reversednumarray = new int[num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            reversednumarray[i] = num[i];
        }

        foreach (int reversenum in reversednumarray)
        {
            Console.WriteLine(reversenum);
        }
    }
}