namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 5;
            string aleatorio;
            char[] palavraSecreta, palavra;
            ObterPalavraAleatoria(out aleatorio, out palavraSecreta, out palavra);

            while (cont >= 0)
            {
                MostarForca(cont);
                Console.WriteLine($"\nVocê tem {cont} tentativas.\n");
                ImprimirPalavra(aleatorio, palavraSecreta);

                Console.WriteLine();
                char chute = ObterChute();
                bool erro = AvaliarChute(aleatorio, palavraSecreta, palavra, ref cont, chute);
                Console.WriteLine();


                for (int i = 0; i < aleatorio.Length; i++)
                {
                    if (chute == palavra[i])
                    {
                        palavraSecreta[i] = chute;

                    }

                }
                bool igais = PalavraDesvendada(palavraSecreta, palavra);
                if (igais)
                {
                    Console.WriteLine($"Parabéns você Acertou!");
                    Console.Write($"A Palavra é {aleatorio}");
                    break;
                }


            }


            Console.ReadLine();

        }

        private static void ObterPalavraAleatoria(out string aleatorio, out char[] palavraSecreta, out char[] palavra)
        {
            Random num = new Random();
            int numLista = num.Next(0, 29);
            string[] listaPalavra = { "ABACATE", "ABACAXI", "ABACATE", "ACEROLA",
                "AÇAÍ", "ARAÇA", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ",
                "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI",
                "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
            aleatorio = listaPalavra[numLista];
            palavraSecreta = new char[aleatorio.Length];
            palavra = aleatorio.ToCharArray();
        }

        private static bool PalavraDesvendada(char[] palavraSecreta, char[] palavra)
        {
            if (palavra.SequenceEqual(palavraSecreta))
            {
                
                return true;
            }
            return false;   
        }

        private static void ImprimirPalavra(string aleatorio, char[] palavraSecreta)
        {
            for (int i = 0; i < aleatorio.Length; i++)
            {

                Console.Write($"{palavraSecreta[i]}");

                if (palavraSecreta[i] == 0)
                    Console.Write($"_");

            }
            Console.WriteLine();
        }

        static void MostarForca(int cont)
        {
            Console.Clear();

            if (cont == 4)
                Console.Write("---------- \n " +
                "|/   \t | \n " +
                "| \t O\n " +
                "| \n " +
                "| \n " +
                "| \n " +
                "| \n " +
                "|\n" +
                "_|____");

            else if (cont == 3)
                Console.Write("---------- \n " +
               "|/   \t | \n " +
               "| \t O\n " +
               "| \t/ \n " +
               "| \n " +
               "| \n " +
               "| \n " +
               "|\n" +
               "_|____");

            else if (cont == 2)
                Console.Write("---------- \n " +
                "|/   \t | \n " +
                "| \t O\n " +
                "| \t/X\n " +
                "| \n " +
                "| \n " +
                "| \n " +
                "|\n" +
                "_|____");

            else if (cont == 1)
                Console.Write("---------- \n " +
               "|/   \t | \n " +
               "| \t O\n " +
               "| \t/X)\n " +
               "| \n " +
               "| \n " +
               "| \n " +
               "|\n" +
               "_|____");

            else if (cont == 0)
                Console.Write("---------- \n " +
                "|/   \t | \n " +
                "| \t O\n " +
                "| \t/X)\n " +
                "| \t X \n " +
                "| \n " +
                "| \n " +
                "|\n" +
                "_|____");

            else if (cont == 5 )
                Console.Write("---------- \n " +
                          "|/   \t | \n " +
                          "| \n " +
                          "| \n " +
                          "| \n " +
                          "| \n " +
                          "| \n " +
                          "|\n" +
                          "_|____\n");

            Console.WriteLine();
        }

        static bool AvaliarChute(string aleatorio, char[] palavraSecreta, char[] palavra, ref int cont, char chute)
        {
            for (int i = 0; i < aleatorio.Length; i++)
            {

                if (chute == palavra[i])
                {
                    return true;

                }



            }
            cont--;
            return false;
        }


        static char ObterChute()
        {
            Console.Write("Qual é seu chute? ");
            char chute = Convert.ToChar(Console.ReadLine());
            return chute;
        }


    }
}
