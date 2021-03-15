using System;
/*
    Вариант 7
    Циклы с контролем за монотонной величиной
 */
namespace _3 {
    class Program3 {
        static void Main(string[] args) {
            double x, epsilon;
            Console.WriteLine("Enter x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter epsilon");
            epsilon = double.Parse(Console.ReadLine());
            int i;
            double tmp = 1;
            double res = tmp;
            for (i = 0; Math.Abs(tmp) > epsilon; i++) {
                tmp *= x * x / (4 * i * i + 6 * i + 2);
                res += tmp;
            }
            Console.WriteLine($"res is {res} with {i + 1} iterations");
        }
    }
}
