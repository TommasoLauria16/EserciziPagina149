using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;

namespace matematica
{
    class FunzioniMatematica
    {
        public static int Somma(int a, int b)
        {
            int somma = a + b;
            return somma;
        }

        public static double SommaDouble(double a, double b)
        {
            double somma = a + b;
            return somma;
        }
        public static double Sottrazione(double a, double b)
        {
            double sottrazione = a - b;
            return sottrazione;
        }
        public static double Moltiplicazione(double a, double b)
        {
            double moltiplicazione = a * b;
            return moltiplicazione;
        }
        public static double Divisione(double a, double b)
        {
            double divisione = a / b;
            return divisione;
        }
        public static long Potenza(int a, int b)
        {
            int i;
            long potenza = 1;
            for (i = 0; i < b; i++)
            {
                potenza = potenza * a;
            }
            return potenza;
        }
        public static long CalcolaFattoriale(int a)
        {
            long fattoriale = 1;
            for (int i = 2; i <= a; i++)
            {
                fattoriale = fattoriale * i;
            }
            return fattoriale;
        }
        public static int MinorTra(int n1, int n2, int n3)
        {
            int Min = Math.Min(n1, Math.Min(n2, n3));
            return Min;
        }
        public static int MaggioreTra(int n1, int n2, int n3)
        {
            int max = Math.Max(n1, Math.Max(n2, n3));
            return max;
        }
        public static double inverso(double a)
        {
            double inverso = a * -1;
            return inverso;
        }
        public static bool isPari(int a)
        {
            return a % 2 == 0;
        }
        public static bool isdispari(int a)
        {
            return a % 2 == 1;
        }
        public static bool isPositivo(int a)
        {
            return a > 0;
        }
        public static bool isNegativo(int a)
        {
            return a < 0;
        }
        public static bool isIntero(double a)
        {
            return a==(int)a;
        }

    }
}

