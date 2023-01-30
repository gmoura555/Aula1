namespace OperadorCoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string curso = null;
            string texto = curso ?? "Curso não informado";
            Console.WriteLine("Curso: " + texto);
            Console.WriteLine(new String ('-', 50));
            Console.WriteLine("texto \"longo\" e esta linha deve ir para \n linha de baixo");
            Console.WriteLine("codigo    \tProduto      \t Preco");
            Console.WriteLine("001       \tMouse         \t R$ 12,78");
            Console.WriteLine("002       \tteclado       \tR$ 12,78");
            Console.WriteLine("003       \tMonitor       \tR$ 312,78");

        }
    }
}