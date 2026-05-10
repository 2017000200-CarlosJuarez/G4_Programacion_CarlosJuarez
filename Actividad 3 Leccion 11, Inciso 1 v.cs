internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2, s = 0;

        Console.WriteLine("Ingrese el primer numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        n2 = Convert.ToInt32(Console.ReadLine());

        n1=n1+1;
        do
        {
            if (n1 < n2)
            {
                s = s + n1;
            }
            n1=n1+1;
        } while (n1 < n2);

        Console.WriteLine("La suma es: " + s);
    }
}