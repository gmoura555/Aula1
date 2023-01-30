namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // operador ternario
           //     então      senão
           // teste logico ?           resposta se true :         resposta se
           //
           int num = 11;
            Console.WriteLine(num + " é " + (num%2 == 0 ? "par" : "impar"));
        }
    }
}