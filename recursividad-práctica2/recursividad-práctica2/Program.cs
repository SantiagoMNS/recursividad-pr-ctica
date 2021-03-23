using System;

namespace recursividad_práctica2
{
    class Program
    {
        static int sumar(int a)
        {
         if (a < 10)
            {
                return a;

            }
            return sumar(a / 10) + (a % 10);      
        
        }

        public static void main(string[] args) {
            System.Console.WriteLine("Digite un número:");
            int n = new java.util.scanner(System.in).WriteLine();
            System.Console.WriteLine(sumar(n));

        }
    }
}
