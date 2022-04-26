using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Demo
{
    internal class Person
    {
        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        private string _codiceFiscale; //Campo calcolato


        public string CodiceFiscale
        {
            get
            {
                _codiceFiscale = FirstName.Substring(0, 3) + LastName.Substring(0, 3) + BirthDay.Year;
                return _codiceFiscale;
            }
        }

        private double Stipendio { get { return 1200.50; } }

        public string GetInfoPersona()
        {
            string infoPersona = $"Codice fiscale: {_codiceFiscale} - Stipendio: {Stipendio}";
            //Console.WriteLine(CodiceFiscale);
            //Console.WriteLine(_codiceFiscale);
            return infoPersona;            
        }

        //overload
        public string GetInfoPersona(string value)
        {
            return $"Nuova info: {value}";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} nato il: {BirthDay.ToShortDateString()}";
        }
    }
}
