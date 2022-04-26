using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Demo
{
    internal class Studente : Person
    {
        public int Matricola { get; set; }

        public override void ChiamaTizio()
        {
            Console.WriteLine("Ciao sono uno studente e sto chiamando Tizio");
        }

        public override void Saluta()
        {
            Console.WriteLine("ciao sono uno studente");
        }

        public override string ToString()
        {
            return base.ToString() + "Matricola" + Matricola;
        }
    }
}
