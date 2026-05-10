internal class Program
{
    private static void Main(string[] args)
    {
        int n, s=0;

        do
        {
            Console.WriteLine("Ingrese un numero");
            n = Convert.ToInt32(Console.ReadLine());

            if (n != 9)
            {
                s= s + n;
            }
        } while (n != 9);

        Console.WriteLine("La suma es: " + s);
    }
}