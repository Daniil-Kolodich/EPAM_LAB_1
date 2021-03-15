using System;
/*
    Вариант 7
    Итерационные циклы
    Метод секущих по малости невязки
 */

namespace _2 {
    class Program2 {
        static void Main(string[] args) {
            double a = 0.4, b = 1;
            double value = a switch {
                _ when Func(a) * FuncSecondDerivative(a) > 0 => a,
                _ when Func(b) * FuncSecondDerivative(b) > 0 => b,
                _ => 0,
            };

            double x0, x1 = (a + b) / 2;
            double epsilon = 0.00000001;
            int it = 0;
            do {
                it++;
                x0 = x1;
                x1 = x0 - Func(x0) / FuncDerivative(value);
            }
            while (Math.Abs(x0 - x1) > epsilon);

            Console.WriteLine($"res is {x1} with {it} iteration");
        }

        public static double Func(double x) {
            return x + Math.Sqrt(x) + Math.Pow(x, 1d / 3d) - 2.5;
        }

        public static double FuncDerivative(double x) {
            return 1 + 1d / (2 * Math.Sqrt(x)) + 1d / (3 * Math.Pow(x * x, 1d / 3d));
        }
        public static double FuncSecondDerivative(double x) {
            return -1d / (4 * x * Math.Sqrt(x)) - 2d / (9 * x * Math.Pow(x * x, 1d / 3d));
        }
    }
}
