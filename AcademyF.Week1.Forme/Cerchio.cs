using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme
{
    internal class Cerchio: Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Raggio { get; set; }

        public Cerchio()
        {

        }
        public Cerchio(string nome, int x, int y, double raggio): base(nome)
        {
            //Name = nome;
            X = x;
            Y = y;
            Raggio = raggio;
        }
        public override double CalcolaArea()
        {
            return Math.Pow(Raggio, 2) * Math.PI;
        }
        public override void Disegna()
        {
            Console.WriteLine($"Cerchio: {Name}. Coordinate centro= ({X},{Y})\t Raggio= {Raggio} - AREA= {CalcolaArea()}");
        }
    }
}
