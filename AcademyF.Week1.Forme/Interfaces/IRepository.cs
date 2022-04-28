using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme.Interfaces
{
    internal interface IRepository<T>
    {
        List<T> GetAll();
        bool Aggiungi(T item);
    }
}
