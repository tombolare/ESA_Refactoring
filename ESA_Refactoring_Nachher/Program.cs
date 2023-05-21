using System;

namespace ESA_Refactoring_Nachher
{
    internal class Program
        {
            public static void Main(string[] args)
            {
                Summe();

                /*
                * Testen der Funktion
                */


                Text();
            }

            private static void Text()
            {
                Console.WriteLine("Ergebis der Rechnung:"
                                  + MyMath.subrahiere2Zahlen(1, 2));
                Console.WriteLine("Ergebis der Rechnung:"
                                  + MyMath.subrahiere2Zahlen(5, 2));
                Console.WriteLine("Ergebis der Rechnung:"
                                  + MyMath.subrahiere2Zahlen(3, 3));
            }

            private static void Summe()
            {
                // Statische Methoden der Klasse MyMath testen
                Console.WriteLine("Summe von 1,2,3: "
                                  + MyMath.Summiere3Zahlen(1, 2, 3));
                Console.WriteLine("Summe von -1,-2,3: "
                                  + MyMath.Summiere3Zahlen(-1, -2, 3));
            }
        }
}