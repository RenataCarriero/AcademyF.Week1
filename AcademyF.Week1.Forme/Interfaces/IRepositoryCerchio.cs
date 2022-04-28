using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme.Interfaces
{
    internal interface IRepositoryCerchio: IRepository<Cerchio>
    {
        List<Cerchio> GetCerchiByRaggio(double raggio);
    }
}
