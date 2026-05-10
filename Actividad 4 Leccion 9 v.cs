internal class Program
{
    private static void Main(string[] args)
    {
        int n, i= 1, v;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        while (i <= 10)
        {
            v = n * i;
            Console.WriteLine(v);

            i=i+1;
        }
    }
}