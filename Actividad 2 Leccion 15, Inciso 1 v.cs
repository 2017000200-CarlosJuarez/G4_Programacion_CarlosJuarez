internal class Program
{
    private static void Main(string[] args)
    {
        int c = 0, s = 0;

        for (int n = 1; n <= 100; n=n+1)
        {
            int d = 0;
            for (int i = 1; i <= n; i=i+1)
            {
                if (n % i == 0)
                {
                    d=d+1;
                }
            }
            if (d == 2)
            {
                Console.WriteLine(n);
                c=c+1;
                s = s + n;
            }
        }

        Console.WriteLine("Cantidad de primos: " + c);
        Console.WriteLine("Suma de primos: " + s);
    }
}