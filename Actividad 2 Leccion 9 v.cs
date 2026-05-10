internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Niveles");
        int m = 0, ma = 0, mc;
        
        while (m < 350 ) {
            Console.WriteLine("Ingrese su cantidad de monedas");
            mc = Convert.ToInt32(Console.ReadLine());
            m = m + mc;
            Console.WriteLine("Su cantidad de monedas es " + m );
        }
        if ( m >= 350 ) {
            ma = ma + 1;
            Console.WriteLine("Usted a subido de nivel");
            Console.WriteLine("Su nivel es 5");
        }
        //< >
    }
}