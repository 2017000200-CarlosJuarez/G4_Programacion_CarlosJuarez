internal class Program
{
    private static void Main(string[] args)
    {
        int n, f=1, i=1;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        do
        {
            f = f * i;
            i=i+1;

        } while (i <= n);

        Console.WriteLine("El factorial es: " + f);
    }
}