using AcademyF.Week1.Forme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme.Repositories
{
    internal class RepositoryRettangoliMOCK : IRepository<Rettangolo>
    {
        private static List<Rettangolo> rettangoli = new List<Rettangolo>()
        {
            new Rettangolo() { Name = "R1", Base = 10, Altezza = 1 },
            new Rettangolo() { Name = "R2", Base = 20, Altezza = 2 },
            new Rettangolo() { Name = "R3", Base = 30, Altezza = 3 }
        };
        public bool Aggiungi(Rettangolo item)
        {
            if (item == null)
                return false;
            rettangoli.Add(item);
            return true;
        }

        public List<Rettangolo> GetAll()
        {
            return rettangoli;
        }
    }
}
