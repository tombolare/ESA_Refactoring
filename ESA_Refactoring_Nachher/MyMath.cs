namespace ESA_Refactoring_Nachher
{
    class MyMath
    //Ich habe diese Klasse in eine neue Datei mit verschoben mit Refactoring
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

        public static int Summiere3Zahlen(int n1, int n2, int n3)
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
}