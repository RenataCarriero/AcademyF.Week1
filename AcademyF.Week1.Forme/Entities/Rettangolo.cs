using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme
{
    internal class Rettangolo : Forma, IProva
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double CalcolaArea()
        {
            return Base * Altezza;
        }
        public override void Disegna()
        {
            Console.WriteLine($"Rettangolo: {Name} \t Base={Base}\t Altezza={Altezza} - AREA={CalcolaArea()}");
        }

        public void StampaQualcosa()
        {
            Console.WriteLine("Sono un rettangolo e sto stampando qualcosa!");
        }
    }
}
