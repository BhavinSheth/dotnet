using System;

namespace a3
{
    class Program
    {
        static void Main(String[] s)
        {
            Console.WriteLine("enter numerator and denominator : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Solution.integerDivision(n, d);
            Solution.floatDivision(n, d);
            Solution.mixed(n, d);
        }
    }

    static class Solution
    {
        public static void integerDivision(int n, int d)
        {
            Console.WriteLine("quotient : " + n / d + "   with remainder : " + n % d);
        }
        public static void floatDivision(float n, float d)
        {
            Console.WriteLine($"float division answer: {n / 2}");
        }
        public static void mixed(int n, int d)
        {
            Console.WriteLine($"mixed fraction is : {n / d} {n % d}/{d}");
        }
    }
}