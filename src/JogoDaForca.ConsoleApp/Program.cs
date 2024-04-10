namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int contErros = 0;
                string aleatorio;
                char[] palavraSecreta, palavra;
                bool letraEncontrada = false;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                ObterPalavraAleatoria(out aleatorio, out palavraSecreta, out palavra);

               do{
                    MostarForca(contErros);
                    ImprimirPalavra(aleatorio, palavraSecreta);

                    Console.WriteLine();
                    char chute = ObterChute();

                    Console.WriteLine();

                    MostarForca(contErros);

                    for (int i = 0; i < aleatorio.Length; i++)
                    {
                        if (chute == palavra[i])
                        {
                            palavraSecreta[i] = chute;
                            letraEncontrada = true;
                        }

                    }

                    if (letraEncontrada == false)
                        contErros++;

                    jogadorEnforcou = contErros >= 5;
                    jogadorAcertou = palavra.SequenceEqual(palavraSecreta);

                    if (jogadorAcertou)
                        Console.WriteLine($"Parabéns você Acertou! A Palavra é {aleatorio}");

                    else if (jogadorEnforcou)
                        Console.WriteLine($"que pena você perdeu! A Palavra era {aleatorio}");




                } while (jogadorEnforcou == false && jogadorAcertou == false) ;
                if (Continuar())
                    break;
            }
            Console.Clear();
            

        }
        static bool Continuar()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja repetir? [S,N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "S";
        }
        private static void ObterPalavraAleatoria(out string aleatorio, out char[] palavraSecreta, out char[] palavra)
        {
            Random num = new Random();
            int numLista = num.Next(0, 29);
            string[] listaPalavra = { "ABACATE", "ABACAXI",  "ACEROLA",
                "AÇAÍ", "ARAÇA", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ",
                "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI",
                "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
            aleatorio = listaPalavra[numLista];
            palavraSecreta = new char[aleatorio.Length];
            palavra = aleatorio.ToCharArray();
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

        static void MostarForca(int contErros)
        {
            Console.Clear();

            string cabecaDoBoneco = contErros >= 1 ? " o " : " ";
            string tronco = contErros >= 2 ? "x" : " ";
            string troncoBaixo = contErros >= 2 ? " x " : " ";
            string bracoEsquerdo = contErros >= 3 ? "/" : " ";
            string bracoDireito = contErros >= 3 ? @"\" : " ";
            string pernas = contErros >= 4 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");

            Console.WriteLine();
        }

        static char ObterChute()
        {
            Console.Write("Qual é seu chute? ");
            char chute = Convert.ToChar(Console.ReadLine().ToUpper());
            return chute;
        }


    }
}
