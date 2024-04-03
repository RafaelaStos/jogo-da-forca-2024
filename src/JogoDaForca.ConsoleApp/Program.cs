namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aleatorio = "ABACATE";
            char[] palavraSecreta = new char[aleatorio.Length];
            char [] palavra = aleatorio.ToCharArray();
            int cont = 5;
            /*
            Console.Write(" ----------");
            Console.Write(" \n |/ \n | \n | \n | \n | \n | \n |");
            Console.Write("\n_|____");

            Console.WriteLine("\n");
           */

            
            for (int i = 0; i < aleatorio.Length; i++)
            {
                
                Console.Write("_");
               
            }
            Console.WriteLine();
            
            while (cont!=0)
            {
                Console.WriteLine();
                char chute = ObterChute();
                bool erro= AvaliarChute(aleatorio, palavraSecreta, palavra, ref cont, chute);
               
               if (erro == false) {

                    if (cont == 4)
                        Console.WriteLine(" O");
                    else if (cont == 3)
                        Console.WriteLine("(x)");
                    else if (cont == 2)
                        Console.WriteLine(" X");
                    else if (cont == 1)
                        Console.Write("/");
                    else if (cont == 0)
                        Console.WriteLine("| ");
                }

                for (int i = 0; i < aleatorio.Length; i++)
                {
                    Console.Write($"{palavraSecreta[i]}");
                    if (palavraSecreta[i] == 0)
                        Console.Write($"_");

                }

                Console.WriteLine();

                
            }




            Console.ReadLine();
        }

        private static bool AvaliarChute(string aleatorio, char[] palavraSecreta, char[] palavra, ref int cont, char chute)
        {
            for (int i = 0; i < aleatorio.Length; i++)
            {

                if (chute == palavra[i])
                {
                    palavraSecreta[i] = chute;
                    return true;
                }



            }
            cont--;
            return false;
        }


        private static char ObterChute()
        {
            Console.Write("Qual é seu chute? ");
            char chute = Convert.ToChar(Console.ReadLine());
            return chute;
        }
    }
}
