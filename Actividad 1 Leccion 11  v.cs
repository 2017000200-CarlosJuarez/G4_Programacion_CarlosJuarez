internal class Program
{
    private static void Main(string[] args)
    {
        int a=0, l=200;

        do
        {
            Console.WriteLine("Cajones disponibles: " + l);
            a=a+1;
            l=200 - a;
        } while (l > 0);

        Console.WriteLine("Ya no hay cajones libres");
    }
}