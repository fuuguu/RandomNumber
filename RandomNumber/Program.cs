internal class Program
{
    private static void Main(string[] args)
    {
        Random random= new Random();
        

        while (true)
        {
            int value = random.Next(0,100);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}