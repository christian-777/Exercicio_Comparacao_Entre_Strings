internal class Program
{
    private static void Main(string[] args)
    {
        string val1;
        string? val2;

        Console.WriteLine("Digite a referencia: ");
        val1=Console.ReadLine();

        Console.WriteLine("Digite o que ira comparar: ");
        val2 = Console.ReadLine();

        if (val1.Equals(val2))
        {
            Console.WriteLine("Sao iguais");
        }
        else
        {
            Console.WriteLine("Nao sao iguais");
        }
    }
}