using System;

namespace Nachher
{
    class MyMath
    {

        /**
     * Diese Methode berechnet und liefert die Summe von 3 Zahlen vom Typ int.
     * 
     * @param n1
     *            erste Zahl
     * @param n2
     *            zweite Zahl
     * @param n3
     *            dritte Zahl
     * @return die Summe der Zahlen
     */

        public static int summiere3Zahlen(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        /**
     * Diese Methode berechnet und liefert das Ergebnis von 2 Zahlen vom Typ int die Subtrahiert werden.
     * 
     * @param n
     *            erste Zahl
     * @param t
     *            zweite Zahl
     * @return die Ergebnis der Zahlen
     */

        public static int subrahiere2Zahlen(int n, int t)
        {
            return n - t;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Statische Methoden der Klasse MyMath testen
            Console.WriteLine("Summe von 1,2,3: "
                              + MyMath.summiere3Zahlen(1, 2, 3));
            Console.WriteLine("Summe von -1,-2,3: "
                              + MyMath.summiere3Zahlen(-1, -2, 3));

            /*
            * Testen der Funktion
            */


            Console.WriteLine("Ergebis der Rechnung:"
                              + MyMath.subrahiere2Zahlen(1, 2));
            Console.WriteLine("Ergebis der Rechnung:"
                              + MyMath.subrahiere2Zahlen(5, 2));
            Console.WriteLine("Ergebis der Rechnung:"
                              + MyMath.subrahiere2Zahlen(3, 3));
        }
    }
}