using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        
        int len = arr.Count;
        
        decimal pc , nc, zc;
        pc=0;
        nc=0;
        zc=0;
        
        foreach(var n in arr)
        {
            if (n>0)
                pc++;
            else if (n<0)
                nc++;
            else
                zc++;        
        }
        
        pc = pc / len;
        
        nc = nc / len;
        
        zc = zc / len;
        
        Console.WriteLine("{0:F6}",pc);
        Console.WriteLine("{0:F6}",nc);
        Console.WriteLine("{0:F6}",zc);
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
