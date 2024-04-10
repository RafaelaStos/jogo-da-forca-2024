using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public class JogoForca
    {
        public int contErros = 0;
        public string aleatorio;
        public char[] palavraSecreta, palavra;
        public bool letraEncontrada = false;
        public bool jogadorEnforcou = false;
        public bool jogadorAcertou = false;
        public bool Continuar()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja repetir? [S,N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "S";
        }
       

        public void ImprimirPalavra(string aleatorio, char[] palavraSecreta)
        {
            for (int i = 0; i < aleatorio.Length; i++)
            {

                Console.Write($"{palavraSecreta[i]}");

                if (palavraSecreta[i] == 0)
                    Console.Write($"_");

            }
            Console.WriteLine();
        }

        public void MostarForca(int contErros)
        {
            Console.Clear();

            string cabecaDoBoneco = contErros >= 1 ? " o " : " ";
            string tronco = contErros >= 2 ? "x" : " ";
            string troncoBaixo = contErros >= 2 ? " x " : " ";
            string bracoEsquerdo = contErros >= 3 ? "/" : " ";
            string bracoDireito = contErros >= 3 ? @"\" : " ";
            string pernas = contErros >= 4 ? "/ \\" : " ";

            
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

        public char ObterChute()
        {
            Console.Write("Qual é seu chute? ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            return letra;

        }
    }
}
