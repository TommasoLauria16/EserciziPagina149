using System;

namespace Matematica
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
            long molt = FunzioniMatematica.CalcolaFattoriale(20);
            Console.WriteLine($"il fattoriale è {molt}");
            int min = FunzioniMatematica.MinorTra(3, 4, 5);
            Console.WriteLine($"il minimo è {min}");
            int max = FunzioniMatematica.MaggioreTra(3, 4, 5);
            Console.WriteLine($"il massimo è {max}");
            double inverso = FunzioniMatematica.Inverso(3);
            Console.WriteLine($"il numero inverso è {inverso}");
            bool pari = FunzioniMatematica.IsPari(4);
            Console.WriteLine($"il numero è pari {pari}");
            bool dispari = FunzioniMatematica.IsDispari(4);
            Console.WriteLine($"il numero è dispari{dispari}");
            bool positivo= FunzioniMatematica.IsPositivo(4);
            Console.WriteLine($"il numero è positivo: {positivo}");
            bool negativo = FunzioniMatematica.IsNegativo(4);
            Console.WriteLine($"il numero è positivo: {negativo}");
            bool intero = FunzioniMatematica.IsIntero(4);
            Console.WriteLine($"il numero è intero: {intero}");
            

        }
    }
}
