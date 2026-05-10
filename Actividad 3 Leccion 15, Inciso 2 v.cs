
internal class Program
{
    private static void Main(string[] args)
    {
        int c=0, s=0;

        for (int n = 300; n >= 1; n=n-1)
        {
            Console.WriteLine(n);
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
                c=c+1;
            }
            if (n % 2 == 0)
            {
                s = s + n;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + c);
        Console.WriteLine("Suma de numeros pares: " + s);
    }
}