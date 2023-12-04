// See https://aka.ms/new-console-template for more information

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("2");

        Console.WriteLine("number= ");
        int number=Convert.ToInt32(Console.ReadLine());

        bool isPrime = IsPrime(number);
        if (isPrime)
        {
            Console.WriteLine("Число є простим " + number);
        }
        else
        {
           Console.WriteLine("Число не є простим " +number);
        }

    }
    static bool IsPrime(int n)
    {
        if (n<=1)
        {
            return false;
        }
        for (int i = 2; i<=Math.Sqrt(n); i++)
        {
            if (n%i==0)
            {
                return false;
            }
        }
        return true;
    }
}