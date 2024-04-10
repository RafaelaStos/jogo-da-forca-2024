using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
   public class ListaPalavra : JogoForca
    {
        public void ObterPalavraAleatoria(out string aleatorio, out char[] palavraSecreta, out char[] palavra)
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
    }
}
