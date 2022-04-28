using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme
{
    internal class Triangolo: Forma
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double CalcolaArea()
        {
            return Base * Altezza / 2;
        }
        public override void Disegna()
        {
            Console.WriteLine($"Triangolo: {Name}. Base={Base}, Altezza={Altezza} - AREA= {CalcolaArea()}");
        }
    }
}
