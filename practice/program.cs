using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayHeader();

        int num1 = 10;
        int num2 = 3;
        int remainder;

        int quotient = DivideWithRemainder(num1, num2, out remainder);
        DisplayResult(num1, num2, quotient, remainder);
    }

    static void DisplayHeader()
    {
        Console.WriteLine($"=== Division Calculator ===");
    }

    static int DivideWithRemainder(int dividend, int divisor, out int remainder)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        return quontite;
    }

    static void DisplayResult(int divident, int divisor, int quotient, int remainder)
    {
        Console.WriteLine($"{divident} / {divisor} = {quotient} with a remainde of {remainder}");
    }
}