namespace OperadoresBoolERelacionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a = b -> esta recebendo o valor de b
            //a == b -> é igual a b Comparacao o resultado
            //true ou false

            int a = 10;
            int b = 20;

            Console.WriteLine("Valo de a: " + a);
            Console.WriteLine("Valo de b: " + b);

            Console.WriteLine(" a == b : " + (a == b)); // false
            Console.WriteLine(" a != b : " + (a != b)); // true
            Console.WriteLine(" a > b : " + (a > b)); // false
            Console.WriteLine(" a < b : " + (a < b)); // true
            Console.WriteLine(" a <= b : " + (a <= b)); // true
            Console.WriteLine(" a >= b : " + (a >= b)); // false

            Console.WriteLine(new String('-', 50));
            /*Operadores Logicos
             *  && - AND -> e verdade quando tudo e verdade
             * || - OR -> ou  verdade qd ao menos uma declaração é true
             * ! - NOT - Nao
             */
            int w = 30, x = 40, y = 50, z = 60;
            // true ou true
            Console.WriteLine("w < x " + (w < x )); // true


        }
    }
}