
internal class Program
{
    private static void Main(string[] args)
    {
        int o, ca = 0, cn = 0, da = 0;

        do
        {
            Console.WriteLine("1- Adulto Q15");
            Console.WriteLine("2- Niño Q10");
            Console.WriteLine("3- Salir");
            o = Convert.ToInt32(Console.ReadLine());

            if (o == 1)
            {
                ca = ca + 1;
                da = da + 15;
            }
            if (o == 2)
            {
                cn = cn + 1;

                da = da + 10;
            }
        } while (o != 3);

        Console.WriteLine("Boletos adultos: " + ca);
        Console.WriteLine("Boletos niños: " + cn);
        Console.WriteLine("Total de boletos: " + (ca + cn));
        Console.WriteLine("Total de dinero: Q" + da);
    }
}