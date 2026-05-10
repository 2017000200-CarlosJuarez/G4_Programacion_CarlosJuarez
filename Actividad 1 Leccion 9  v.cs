internal class Program
{
    private static void Main(string[] args)
    {
        double pa = 0, pm, m = 0;

        while (pa < 1000)
        {
            Console.WriteLine("Ingrese el peso de la manzana en gramos (solo puede comprar manzanas de 100-300)");
            pm = Convert.ToDouble(Console.ReadLine());
            if (pm >= 100 && pm <= 300)
            {
                pa = pa + pm;
                Console.WriteLine("El peso acumulado es " + pa);
                m = m + 1;
                Console.WriteLine("Lleva " + m + " manzanas");
            }
            else
            {
                Console.WriteLine("ERROR, Esa manzana no cumple con el peso solicitado");
            }
        }
        Console.WriteLine("Meta alcanzada, ya tiene " + (pa / 1000) + " kg en la bolsa");
        Console.WriteLine("Su total de manzanas fue " + m);
    }
}