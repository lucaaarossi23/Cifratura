using System;
using System.Collections.Generic;
using System.Text;

namespace Cifratura
{
    internal class Cifrario
    {
        //per Rot13 basta dichiarare k come costante = 13
        public static string Cifra(string testo, int k)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string risultato = "";

            for (int i = 0; i < testo.Length; i++)
            {
                char lettera = testo[i];
                int posizione = alfabeto.IndexOf(lettera);

                if (posizione != -1) 
                {
                    risultato += alfabeto[(posizione + k) % 26];
                }
                else // posizione non è tra le lettere dell'alfabeto
                {
                    risultato += lettera;
                }
            }

            return risultato;
        }

        public static string Decifra(string testo, int k)
        {
            return Cifra(testo, (26 - k % 26) % 26); //per decifrare basta "ricifrare" il testo usando semplicemente il corrispondente k (tenendo in considerazione che k potrebbe essere anche > 26)
        }
    }
}
