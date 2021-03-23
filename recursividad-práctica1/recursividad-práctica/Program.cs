using System;

namespace recursividad_práctica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int resultado = sumaRecursividad(n);
            System.Console.WriteLine("La suma de los números es = " + resultado);

        }

        public static int sumaRecursividad (int numero)
        {

            int res;

            if(numero==1)
            {
                return 1;
            }else
            {
                res = numero + sumaRecursividad(numero-1);

            }

            return res;
        }
    }
}
