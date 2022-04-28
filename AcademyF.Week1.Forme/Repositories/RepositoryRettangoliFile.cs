using AcademyF.Week1.Forme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Forme.Repositories
{
    internal class RepositoryRettangoliFile : IRepository<Rettangolo>
    {
        string path = @"C:\Users\RenataCarriero\source\repos\AcademyF.Week1\AcademyF.Week1.Forme\Repositories\Rettangoli.txt";
        public bool Aggiungi(Rettangolo item)
        {
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{item.Name},{item.Base},{item.Altezza}");
            }
            return true;
        }

        public List<Rettangolo> GetAll()
        {
            List<Rettangolo> rettangoli=new List<Rettangolo>();
            using(StreamReader sr=new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd();

                if(string.IsNullOrEmpty(contenutoFile))//(contenutoFile==null || contenutoFile == "")
                {
                    return rettangoli;
                }
                else
                {
                    var righeDelFile=contenutoFile.Split("\r\n");
                    for(int i = 0; i < righeDelFile.Length-1; i++)
                    {
                        var campiDellaRiga=righeDelFile[i].Split(",");
                        Rettangolo r=new Rettangolo();
                        r.Name= campiDellaRiga[0];
                        r.Base = double.Parse(campiDellaRiga[1]);
                        r.Altezza = double.Parse(campiDellaRiga[2]);
                        rettangoli.Add(r);
                    }
                }
                return rettangoli;
            }
        }
    }
}
