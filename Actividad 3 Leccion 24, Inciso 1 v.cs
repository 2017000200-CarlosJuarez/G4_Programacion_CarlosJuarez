
internal class Program
{
    private static void Main(string[] args)
    {
        int d, s = 0;

        for (int n = 1; n <= 50; n=n+1)
        {
            d = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    d=d+1;
                }
            }
            if (d == 2)
            {
                s = s + n;
            }
        }

        Console.WriteLine("La suma de los numeros primos es: " + s);
    }
}