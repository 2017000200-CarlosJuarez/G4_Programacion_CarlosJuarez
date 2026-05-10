internal class Program
{
    private static void Main(string[] args)
    {
        int n, i=1, c=0;

        Console.WriteLine("Ingrese un numero");
        n= Convert.ToInt32(Console.ReadLine());

        while (i <= n)
        {
            if (n % i == 0)
            {
                c=c+1;
            }

            i=i+1;
        }

        if (c == 2)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es primo");
        } 
    }
}