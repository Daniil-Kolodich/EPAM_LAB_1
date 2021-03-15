using System;
/*
    Вариант 7
    Арифметические циклы 
 */
namespace _1 {
    class Program1 {
        class Program {
            static void Main(string[] args) {
                double x;
                int k;
                Console.WriteLine("ent x");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("ent k (num of iteration)");
                k = int.Parse(Console.ReadLine());
                double res = 0;
                for (int i = 0; i <= k; i++) {
                    res += (2 * i + 1) * Math.Pow(x, 2 * i) / GetFactorial(i);
                }
                Console.WriteLine($"res is {res}");
            }

            public static long GetFactorial(int num) {
                if (num <= 1)
                    return 1;
                long res = 1;
                for (int i = 2; i <= num; i++)
                    res *= i;
                return res;
            }
        }
    }
}
