using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int n, i = 0;

        Console.WriteLine("Ingrese un numero");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Numeros impares:");

        while (i <= n)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }

            i=i+1;
        }

        Console.WriteLine("Numero ingresado: " + n);
    }
}