internal class Program
{
    private static void Main(string[] args)
    {
        int s = 0;

        for (int n = 1; n <= 22; n=n+1)
        {
            int c = 0;
            for (int i = 1; i <= n; i=i+1)
            {
                if (n % i == 0)
                {
                    c=c+1;
                }
            }

            if (c == 2)
            {
                s = s + n;
            }
        }

        Console.WriteLine("La suma de los numeros primos es: " + s);
    }
}