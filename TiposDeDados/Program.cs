namespace TiposDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Guilherme";
            int idade = 10;
            idade = 30;
            float salario = 1500.000000000F;
            double comissao = 2000.89;
            decimal juros = 0.9845654568423218651216M;

            bool maiorDeIdade = false;
            char _teste = '1';

            var x = 10;
            x =

            //concatenar modo 1

            Console.WriteLine("Nome do Aluno" +nome);
            Console.WriteLine("Idade do Aluno" + idade);
            Console.WriteLine(salario);


            Console.WriteLine($"Nome: {nome}, salário: {salario}, É maior de Idade: {maiorDeIdade}");
        }
    }
}