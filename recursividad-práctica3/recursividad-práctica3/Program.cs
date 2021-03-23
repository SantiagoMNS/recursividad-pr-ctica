namespace recursividad_práctica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("Digite un número:");
            System.Console.WriteLine(1);

        }

       public static bool primo(int n, int c)
            {
                if (c == 1)
                {
                    return true;
                }
                else
                      if (n == 0)
                {

                    return false;
                }
                else
                    return primo(n, c - 1);

            }
       

    }
}
