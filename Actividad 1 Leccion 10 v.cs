internal class Program
{
    private static void Main(string[] args)
    {
        const int ts = 8;

        Console.WriteLine("Bienvenido a la Barberia PRESI");

        for (int i = 1; i <= ts; i++)
        {
            Console.WriteLine("Sellos actuales: {0} de {1}", i, ts);
            Console.WriteLine("Presione cualquier tecla para registrar esta visita");
            Console.ReadKey();
            Console.WriteLine(">>>Sello #{0}: Registrado correctamente", i);
        }

        Console.WriteLine("\n------------------------");
        Console.WriteLine("cuponera completada");
        Console.WriteLine("David se a llevado un corte gratis");
        Console.WriteLine("------------------------");
    }
}