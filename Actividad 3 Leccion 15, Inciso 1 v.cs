internal class Program
{
    private static void Main(string[] args)
    {
        int m, s=0, c=0;

        for (int i = 1; i <= 20; i++)
        {
            m = i*7;
            s = s+m;
            if (m%2 == 0)
            {
                c=c+1;
            }
        }

        Console.WriteLine("Suma de los multiplos: " + s);
        Console.WriteLine("Cantidad de multiplos pares: " + c);
    }
}