using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalculator
{
    class Programas
    {
        static void Main(string[] args)
        {
            ArithmeticOperation operationDelegate = Add;

            int result = operationDelegate.Invoke(5, 3);
            Console.WriteLine("Результат додавання: " + result);

            operationDelegate = Subtract;
            result = operationDelegate.Invoke(7, 2);
            Console.WriteLine("Результат віднімання: " + result);

            operationDelegate = Multiply;
            result = operationDelegate.Invoke(4, 6);
            Console.WriteLine("Результат множення: " + result);

            Console.ReadKey();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
