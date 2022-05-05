using AcademyF.Week1.Forme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week2.EsercitazioneLinq
{
    internal static class QueryLinq
    {
        static List<Forma> forme = new List<Forma>()
        {
            new Cerchio{Name="A", X=0,Y=0,Raggio=2},
            new Cerchio{Name="B", X=2,Y=5,Raggio=4.5},
            new Cerchio{Name="C", X=7,Y=3,Raggio=6},
            new Rettangolo{Name="A", Base=10, Altezza=10},
            new Rettangolo{Name="B", Base=3, Altezza=11},
            new Rettangolo{Name="C", Base=2, Altezza=2},
            new Triangolo{Name="A", Base=20, Altezza=3},
            new Triangolo{Name="B", Base=1, Altezza=3},
            new Triangolo{Name="C", Base=13, Altezza=3},
            new Triangolo{Name="D", Base=10, Altezza=10}
        };

        internal static void EsecuzioneQuery()
        {
            Console.WriteLine("--------Elenco di tutte le forme-----------");
            foreach (var item in forme)
            {
                item.Disegna();
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. Forme con Area superiore a 20");
            Console.WriteLine("----------LE");

            var FormeConAreaSuperioreA20 = forme.Where(f => f.Area > 20);
            foreach (var item in FormeConAreaSuperioreA20)
            {
                item.Disegna();
            }
            Console.WriteLine("----------QE");
            var formeConAreaSuperioreA20QueryExp =
                from f in forme
                where f.Area > 20
                select f;
            foreach (var item in formeConAreaSuperioreA20QueryExp)
            {
                item.Disegna();
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("2. Forme con Nome che inizia per A");
            Console.WriteLine("----------LE");

            var formeConNomeCheIniziaConA = forme.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var item in formeConNomeCheIniziaConA)
            {
                item.Disegna();
            }
            Console.WriteLine("----------QE");
            var formeConNomeCheIniziaConAQueryExp =
                from f in forme
                where f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)
                select f;
            foreach (var item in formeConNomeCheIniziaConAQueryExp)
            {
                item.Disegna();
            }


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("3. Solo lista dei nomi delle forme");
            Console.WriteLine("----------LE");

            var listaNomiForme = forme.Select(f => f.Name);
            foreach (var item in listaNomiForme)
            {
                Console.WriteLine("Nome Forma: " + item);
            }

            Console.WriteLine("----------QE");

            var listaNomiFormeQueryExp =
                from f in forme
                select f.Name;
            foreach (var item in listaNomiFormeQueryExp)
            {
                Console.WriteLine("Nome Forma: " + item);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("4. Lista ordinata delle forme. Ordinamento alfabetico sul nome e poi descrescente dull'area");
            Console.WriteLine("----------LE");
            var formeOrdinate = forme.OrderBy(f => f.Name).ThenByDescending(f => f.Area);
            foreach (var item in formeOrdinate)
            {
                item.Disegna();
            }
            Console.WriteLine("----------QE");
            var formeOrdinateQueryExp =
                from f in forme
                orderby f.Name, f.Area descending
                select f;
            foreach (var item in formeOrdinateQueryExp)
            {
                item.Disegna();
            }
        }
    }
}
