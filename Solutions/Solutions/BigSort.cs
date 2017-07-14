using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;

class Bigsort
{
    class Comparer : IComparer<BigInteger>
    {
        public int Compare(BigInteger x, BigInteger y)
        {
            if(x < y)
            {
                return -1;
            }
            else if(x > y)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public static string[] Sort(int n , string[] unsorted)
    {
        return unsorted
            .Select(x => BigInteger.Parse(x))
            .OrderBy(x => x, new Comparer())
            .Select(x => x.ToString())
            .ToArray();
    }

    //static void Main(String[] args)
    //{

    //    int n = Convert.ToInt32(Console.ReadLine());
    //    string[] unsorted = new string[n];
    //    for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
    //    {
    //        unsorted[unsorted_i] = Console.ReadLine();
    //    }

    //    foreach (var s in Sort(n,unsorted))
    //    {
    //        Console.WriteLine(s);
    //    } 
    //}
}

