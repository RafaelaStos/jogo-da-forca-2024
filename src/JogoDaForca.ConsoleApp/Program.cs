namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoForca jogo = new JogoForca();
            ListaPalavra lista = new ListaPalavra();

            while (true)
            {
              lista.ObterPalavraAleatoria(out jogo.aleatorio, out jogo.palavraSecreta, out jogo.palavra);

                do
                {
                    jogo.MostarForca(jogo.contErros);
                    jogo.ImprimirPalavra(jogo.aleatorio, jogo.palavraSecreta);

                    Console.WriteLine();
                    char chute = jogo.ObterChute();

                    Console.WriteLine();
                  

                    for (int i = 0; i < jogo.aleatorio.Length; i++)
                    {
                        if (chute == jogo.palavra[i])
                        {
                            jogo.palavraSecreta[i] = chute;
                            jogo.letraEncontrada = true;
                        }

                    }

                    if (jogo.letraEncontrada == false)
                        jogo.contErros++;

                    jogo.jogadorEnforcou = jogo.contErros >= 5;
                    jogo.jogadorAcertou = jogo.palavra.SequenceEqual(jogo.palavraSecreta);

                    if (jogo.jogadorAcertou)
                       
                        Console.WriteLine($"Parabéns você Acertou! A Palavra é {jogo.aleatorio}");

                    else if (jogo.jogadorEnforcou)
                        Console.WriteLine($"Que pena você perdeu! A Palavra era {jogo.aleatorio}");




                } while (jogo.jogadorEnforcou == false && jogo.jogadorAcertou == false);
                if (jogo.Continuar())
                    break;
            }
            Console.Clear();


        }



    }
}
