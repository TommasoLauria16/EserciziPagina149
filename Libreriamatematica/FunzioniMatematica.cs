using System;


namespace Matematica
{
    public class FunzioniMatematica
    {/// <summary>
     /// questo metodo calcola la somma
     /// </summary>
     /// <param name="a"></param>
     /// <param name="b"></param>
     /// <returns>a+b</returns>
        public static int Somma(int a, int b)
        {
            int somma = a + b;
            return somma;
        }
        /// <summary>
        /// questo metodo calcola la somma double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public static double SommaDouble(double a, double b)
        {
            double somma = a + b;
            return somma;
        }/// <summary>
        /// questo metodo calcola differenza double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a-b</returns>
        public static double Sottrazione(double a, double b)
        {
            double sottrazione = a - b;
            return sottrazione;
        }/// <summary>
        /// questo metodo calcola la moltiplicazione
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*b</returns>
        public static double Moltiplicazione(double a, double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }/// <summary>
        /// questo metodo calcola la divisione
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a/b</returns>
        public static double Divisione(double a, double b)
        {
            double divisione = a / b;
            return divisione;
        }/// <summary>
        /// questo metodo calcola la potenza
        /// </summary>
        /// <param name="a">base</param>
        /// <param name="b">esponente</param>
        /// <returns>a^b</returns>
        public static long Potenza(int a, int b)
        {
            int i;
            long potenza = 1;
            for (i = 0; i < b; i++)
            {
                potenza *= a;
            }
            return potenza;
        }/// <summary>
        /// questo metodo calcola il fattoriale
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static long CalcolaFattoriale(int a)
        {
            long fattoriale = 1;
            for (int i = 2; i <= a; i++)
            {
                fattoriale = fattoriale * i;
            }
            return fattoriale;
        }/// <summary>
        /// questo metodo calcola il fattoriale
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        /// <returns>fattoriale</returns>
        public static int MinorTra(int n1, int n2, int n3)
        {
            int Min = Math.Min(n1, Math.Min(n2, n3));
            return Min;
        }/// <summary>
        /// questo metodo calcola il minore tra tre numeri
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        /// <returns>Min</returns>
        public static int MaggioreTra(int n1, int n2, int n3)
        {
            int max = Math.Max(n1, Math.Max(n2, n3));
            return max;
        }/// <summary>
        /// Inverso
        /// </summary>
        /// <param name="a"></param>
        /// <returns>-a</returns>
        public static double Inverso(double a)
        {
            double inverso = a * -1;
            return inverso;
        }/// <summary>
        /// questo metodo ci dice se è pari 
        /// </summary>
        /// <param name="a"></param>
        /// <returns>a%2==0</returns>
        public static bool IsPari(int a)
        {
            return a % 2 == 0;
        }/// <summary>
        /// questo metodo ci dice se è dispari
        /// </summary>
        /// <param name="a"></param>
        /// <returns>!IsPari(a)</returns>
        public static bool IsDispari(int a)
        {
            return !IsPari(a);
        }/// <summary>
        /// questo metodo ci dice se è positivo
        /// </summary>
        /// <param name="a"></param>
        /// <returns>a>0</returns>
        public static bool IsPositivo(int a)
        {
            return a > 0;
        }/// <summary>
        /// questo metodo dice se è negativo
        /// </summary>
        /// <param name="a"></param>
        /// <returns>a<0</returns>
        public static bool IsNegativo(int a)
        {
            return a < 0;
        }/// <summary>
        /// questo metodo ci dice se è intero
        /// </summary>
        /// <param name="a"></param>
        /// <returns>a==(int)a</returns>
        public static bool IsIntero(double a)
        {
            return a==(int)a;
        }

    }
}

