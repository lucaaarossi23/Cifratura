namespace Cifratura;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci la frase: ");
        string frase = Console.ReadLine().ToUpper();

        Console.Write("Inserisci la chiave K: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("1-Cifra  2-Decifra: ");
        int s = int.Parse(Console.ReadLine());

        switch (s)
        {
            case 1:
                Console.WriteLine(Cifrario.Cifra(frase, k));
                break;

            case 2:
                Console.WriteLine(Cifrario.Decifra(frase, k));
                break;

            default:
                Console.WriteLine("Scelta non valida");
                break;

        }
    }
}