﻿namespace modificador_ref_out;
class Program
{
    static void Main(string[] args)
    {
        int  a = 10;
        Calculator.Triple(ref a);        
        Console.WriteLine(a);
    }
}