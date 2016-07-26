using System.IO;
using System;

class Program
{
    static void Main()
    {
        int num1 = 99;
        double num2 = 0.3525;
        
        int res1;
        res1 = (int)(num1 * num2);
        double res2;
        res2 = num2 * (double)num1;
        
        Console.WriteLine(res1);
        Console.WriteLine(res2);
    }
}
