internal class Program
{
    private static void Main(string[] args)
    {
        int m;

        Console.WriteLine("Primeros 20 multiplos de 4");

        for (int i = 1; i <= 20; i=i+1)
        {
            m = i * 4;

            Console.WriteLine(m);
        }
    }
}