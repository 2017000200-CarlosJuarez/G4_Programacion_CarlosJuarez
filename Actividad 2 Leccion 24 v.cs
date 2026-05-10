
internal class Program
{
    private static void Main(string[] args)
    {
        int n, m;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 20; i=i+1)
        {
            m = n * i;

            Console.WriteLine(m);
        }
    }
}