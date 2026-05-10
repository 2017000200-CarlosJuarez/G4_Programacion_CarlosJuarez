internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;

        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }

            i=i+1;

        } while (i <= 100);
    }
}