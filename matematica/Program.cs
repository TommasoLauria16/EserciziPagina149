using System;

namespace matematica
{
    class Program
    {
        public static void Main(string[] args)
        {
            int somma = FunzioniMatematica.Somma(3, 4);
            Console.WriteLine($"la somma intera è: {somma}");
            double sommaDouble = FunzioniMatematica.SommaDouble(3.0,4.0);
            Console.WriteLine($"la somma decimale è: {sommaDouble}");
            double moltiplicazione = FunzioniMatematica.Moltiplicazione(3,4);
            Console.WriteLine($"la moltiplicazione è: {moltiplicazione}");
            double divisione = FunzioniMatematica.Divisione(3, 4);
            Console.WriteLine($"la divisione è: {divisione}");
            long potenza = FunzioniMatematica.Potenza(3, 4);
            Console.WriteLine($"la potenza è: {potenza}");
            long molt = FunzioniMatematica.CalcolaFattoriale(8);
            Console.WriteLine($"il fattoriale è {molt}");
            int Min = FunzioniMatematica.MinorTra(3, 4, 5);
            Console.WriteLine($"il minimo è {Min}");
            int max = FunzioniMatematica.MaggioreTra(3, 4, 5);
            Console.WriteLine($"il massimo è {max}");
            double inverso = FunzioniMatematica.inverso(3);
            Console.WriteLine($"il numero inverso è {inverso}");
            bool pari = FunzioniMatematica.isPari(4);
            Console.WriteLine($"il numero è pari {pari}");
            bool dispari = FunzioniMatematica.isdispari(4);
            Console.WriteLine($"il numero è dispari{dispari}");
            bool positivo= FunzioniMatematica.isPositivo(4);
            Console.WriteLine($"il numero è positivo: {positivo}");
            bool negativo = FunzioniMatematica.isNegativo(4);
            Console.WriteLine($"il numero è positivo: {negativo}");
            bool intero = FunzioniMatematica.isIntero(4.4);
            Console.WriteLine($"il numero è intero: {intero}");

        }
    }
}
