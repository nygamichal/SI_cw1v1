using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_cw1v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 7, 7, 1, 8, 3, 3 };
            int[] tab2 = new int[] { 8, 6, 6, 6, 7 };

            int min = fMin(tab);
            Console.WriteLine("Wartość minimalna tablicy to: " + min);

            int[] unikalne = fUnikalnosc(tab2);
            string wynik = string.Join(", ", unikalne);
            Console.WriteLine("Unikalne liczby tabeli to: " + wynik);

            int[][] tab10 = new int[][]{new int[]{7,4,5,6},
                                       new int[]{3,4,5,5},
                                       new int[]{7,6,7,4}};
            int[] tab3 = fKolumna(tab10, 2);
            string wynik2 = string.Join(",", tab3);
            Console.WriteLine("Wartości w kolumnie 2 to: " + wynik2);

            Dictionary<int, int> st = fCzestosc(tab);
            string wynik3 = string.Join(" \n", st);
            Console.WriteLine("Częstość występowania poszczególnych elementów: " + wynik3);

            int[] st2 = fKolumnyJezeli(tab10, 1, 1, 4);
            string wynik4 = string.Join(", ", st2);
            Console.WriteLine("Czestosc wystepowania poszczególnych elementów: " + wynik4);

            Console.ReadKey();
        }

        static int fMin(int[] tab)
        {
            int min = tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if (min > tab[i])
                {
                    min = tab[i];
                }

            }
            return min;
        }
        static int fSuma(int[] tab)
        {
            int suma = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                suma += tab[i];
            }

            return suma;
        }

        static int[] fUnikalnosc(int[] tab)
        {
            List<int> lista = new List<int>();
            lista.Add(tab[0]);
            for (int i = 1; i < tab.Length; i++)
            {
                if (!lista.Contains(tab[i]))
                    lista.Add(tab[i]);
            }
            return lista.ToArray();
        }

        static int[] fKolumna(int[][] tab, int nrKolumny)
        {
            int[] kolumna = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                kolumna[i] = tab[i][nrKolumny];

            }
            return kolumna;
        }


        static Dictionary<T, int> fCzestosc<T>(T[] tab)
        {
            Dictionary<T, int> wynik = new Dictionary<T, int>();
            wynik.Add(tab[0], 1);
            for (int i = 1; i < tab.Length; i++)
            {
                T sprawdzanaliczba = tab[i];
                if (wynik.ContainsKey(sprawdzanaliczba))
                    wynik[sprawdzanaliczba] += 1;
                else
                    wynik.Add(sprawdzanaliczba, 1);
            }
            return wynik;
        }

        // tab.Length <- liczba wierszy
        // tab[0].Length <- liczba elementow w 0 wierszu, w kolumnie
        // pozycja liczby zalezy od tego w ktorym wierszu sie znajduje
        //    static int fSrednia(int[] tab)
        //   {
        //       int suma = fSuma(int[] tab);
        //     return (double)suma / tab.Length;
        //  }

        static int[] fKolumnyJezeli(int[][] tab, int nrKolumny, int nrKolumnyDecyzji, int wartoscDecyzji)
        {
            List<int> kolumna = new List<int>();
            for (int i = 0; i < tab.Length; i++)//ilosc wierszy
            {
                int[] wiersz = tab[i];
                if (wiersz[nrKolumnyDecyzji] == wartoscDecyzji)
                {
                    kolumna.Add(wiersz[nrKolumny]);
                }
            }
            return kolumna.ToArray();
        }

        //deskryptor - konkretny atrybut z wartoscia
        //za ich pomoca opisuejmy obiekty
    }
}