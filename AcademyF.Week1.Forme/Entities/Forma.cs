using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme
{
    internal class Forma
    {
        public string Name { get; set; }
        public double Area { get { return CalcolaArea(); } }

        public Forma()
        {

        }

        public Forma(string nome)
        {
            Name = nome;
        }
        public virtual double CalcolaArea()
        {
            return 0;
        }

        public virtual void Disegna()
        {
            Console.WriteLine("Generica figura geometrica");
        }
    }
}
