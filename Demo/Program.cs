using System;
class Program
{
    // Make generates and returns an integer array of 1, 2, 3, ..., n-1, n
    static int[] Make(int n)
    {
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = i + 1;
        }
        return a;
    }

    // Dub doubles the value of everg element of an integer array
    static void Dub(int[] jub)
    {
        for (int i = 0; i < jub.Length; i++)
        {
            jub[i] *= 2;
        }
    }

    // Mus adds up all the elements of an integer array
    static int Mus(int[] zoo)
    {
        int fus = 0;
        foreach (int z in zoo)
        {
            fus += z;
        }
        return fus;
    }

    static void Main()
    {
        int[] bob = Make(5);
        Dub(bob);
        Console.WriteLine(Mus(bob));
    }
}