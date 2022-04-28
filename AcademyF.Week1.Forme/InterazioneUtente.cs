using AcademyF.Week1.Forme.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme
{
    internal static class InterazioneUtente
    {
        static RepositoryRettangoliMOCK repoRettangoli= new RepositoryRettangoliMOCK();
        internal static void Start()
        {
            bool continua = true;
            while (continua) // continua==true
            {
                int scelta = Menu();
                switch (scelta)
                {
                    case 1:
                        VisualizzaTuttiIRettangoli();
                        break;
                    case 2:
                        //AggiungiRettangolo();
                        break;
                    case 3:
                        //RicercaRettangoloPerNome();
                        break;
                    case 0:
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                    default:
                        Console.WriteLine("Scelta errata.");
                        break;
                }
            }
        }

        private static void VisualizzaTuttiIRettangoli()
        {
            var listaRettangoliRecuperata=repoRettangoli.GetAll();
            if (listaRettangoliRecuperata.Count == 0)
            {
                Console.WriteLine("Lista vuota");
            }
            else
            {
                Console.WriteLine("Ecco l'elenco dei rettangoli");
                foreach (var r in listaRettangoliRecuperata)
                {
                    r.Disegna();
                }
            }
        }

        private static int Menu()
        {
            Console.WriteLine("---------------MENU----------");
            Console.WriteLine("1.Visualizza tutti i Rettangoli");
            Console.WriteLine("2.Aggiungi un Rettangolo");
            Console.WriteLine("3.Cerca un Rettangolo per nome");
            Console.WriteLine("\n0.Exit");
            Console.WriteLine("\nInserisci la tua scelta:");
            //int sceltaUtente=int.Parse(Console.ReadLine());
            int sceltaUtente;
            while (!(int.TryParse(Console.ReadLine(), out sceltaUtente) /*&& sceltaUtente >= 0 && sceltaUtente <= 3*/))
            {
                Console.WriteLine("Riprova. Devi inserire un numero intero.");
            }
            return sceltaUtente;
        }
    }
}
