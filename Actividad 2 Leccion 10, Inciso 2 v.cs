internal class Program
{
    private static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i=i+1)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}