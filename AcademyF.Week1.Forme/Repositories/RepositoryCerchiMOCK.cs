using AcademyF.Week1.Forme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme.Repositories
{
    internal class RepositoryCerchiMOCK : IRepositoryCerchio
    {
        static private List<Cerchio> cerchi = new List<Cerchio>()
        {
            new Cerchio("Cerchio1", 0, 0, 3),
            new Cerchio("Cerchio2", 1, 2, 3),
            new Cerchio("Cerchio3", 1, 2, 2)
        };
        public bool Aggiungi(Cerchio item)
        {
            cerchi.Add(item);
            return true;
        }

        public List<Cerchio> GetAll()
        {
            return cerchi;
        }

        public List<Cerchio> GetCerchiByRaggio(double raggio)
        {
            List<Cerchio> cerchiFiltrati = new List<Cerchio>();
            foreach (var item in cerchi)
            {
                if (item.Raggio == raggio)
                {
                    cerchiFiltrati.Add(item);
                }
            }
            return cerchiFiltrati;
        }
    }
}
