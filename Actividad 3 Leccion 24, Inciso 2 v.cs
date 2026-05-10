internal class Program
{
    private static void Main(string[] args)
    {
        int n, s = 0;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i=i-1)
        {
            Console.WriteLine(i);
            s = s + i;
        }

        Console.WriteLine("La suma es: " + s);
    }
}