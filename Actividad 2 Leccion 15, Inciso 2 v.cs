internal class Program
{
    private static void Main(string[] args)
    {
        int b1, b2, b3, tb, td;

        Console.WriteLine("Cantidad de billetes de 20");
        b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cantidad de billetes de 50");
        b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cantidad de billetes de 100");
        b3 = Convert.ToInt32(Console.ReadLine());

        tb = b1 + b2 + b3;
        td = b3 * 100;

        Console.WriteLine("Total de billetes: " + tb);
        Console.WriteLine("Total de Billetes de 100: " + b3);
        Console.WriteLine("Total de dinero de los billetes de 100: Q" + td);
    }
}