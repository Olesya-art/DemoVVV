using System;

namespace DemoVVV
{
    class Program
    {
        static void Main(string[] args)
        {
            int MeineZahl = 12;

            int PreRueckgabe = PreIncrement(ref MeineZahl);
            int PostRueckgabe = PostIncrement(ref MeineZahl);

        }

        /// Erstellen von Methoden welche ++ nachstellen
        /// 1. Name: PostIncrement
        ///     Originalvariable sichern
        ///     Original erhöhen
        ///     Sicherung zurückgeben
        static int PostIncrement(ref int pZahl)
        {
            int backup;
            backup = pZahl;
            // alternativ  int backup = pZahl;

            pZahl = pZahl + 1; // alternativ  pZahl += 1;
            return backup;
        }


        /// 2. Name: PreIncrement
        ///     Original erhöhen
        ///     Original zurückgeben
        static int PreIncrement(ref int pZahl)
        {
            pZahl = pZahl + 1;
            return pZahl;
        }
    }
}
