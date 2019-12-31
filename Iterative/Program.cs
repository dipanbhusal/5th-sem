using System;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine("Enter the number: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            // int fibNum = Fib_Recursive(num);
            // Console.WriteLine("7th fibonacci Number: " +fibNum);

            GCD_iterative(45,30);
        }
        // static int Fib_Recursive(int n)
        // {
        //     if (n == 1)
        //         return 0;
        //     if (n == 2)
        //         return 1;

        //     return Fib_Recursive(n - 1) + Fib_Recursive(n - 2);
        // }
        // static Fib_Iterative(n){
        //     int i;
        //     int a = 0;
        //     int b = 1;
        //     int fiboArr;
        //     for(i = 3; i <= n; i++)
        //     {
        //         fiboArr = a + b;
                
        //     }
        // }
        stativ GCD_Iterative(int a, int b)
        {
            if(b == 0)
                return a;
            if (a == 0)
                return b;
            while(b != 0)
            {
                int t = b;
                b = a  %  b;
                a = t;
            }
            return a;
        }
    }
}
