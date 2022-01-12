using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
                    //FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    //fibonacciSeries.PrintFibonacciSeries();

                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.ChcekPerfectNumber();
                    
                    //PrimeNumber primeNumber = new PrimeNumber();
                    //primeNumber.CheckPrimeNumber();
                   
                    //ReverseNumber reverseNumber = new ReverseNumber();
                    //reverseNumber.FindReverseNumber();
            //CouponNumber couponNumber = new CouponNumber();
            //couponNumber.Calculation(N);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.Fibonacci Series \n 2.Perfect Number \n 3.Prime Number \n 4.Reverse a Number \n 5.Coupon Number, \n 6.Stopwatch Program, \n 7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.PrintFibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckPrimeNumber();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.FindReverseNumber();
                        break;
                    case 5:
                        Console.Write("How many numbers you wants to generate :");
                        int N = Convert.ToInt32(Console.ReadLine());

                        CouponNumber couponNumber = new CouponNumber();
                        couponNumber.Calculation(N);
                        break;
                    case 6:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Calculate();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
            
        }
        
    }

}
