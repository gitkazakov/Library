using System;

namespace Library1
{
    public class MathOperations
    {
        // Метод для сложения
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Метод для вычитания
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Метод для умножения
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Метод для деления
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно!");
            return (double)a / b;
        }

    }

    public class Library
    {
        static void Main()
        {
            var math = new MathOperations();
            Console.WriteLine($"5 + 10 = {math.Add(5, 10)}");

            MathOperations obj = new MathOperations();

        }
    }
}

