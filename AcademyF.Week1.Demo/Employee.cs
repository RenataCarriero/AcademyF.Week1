using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF.Week1.Demo
{
    internal class Employee : Person
    {
        public string Company { get; set; } = "Avanade";

        public override string ToString()
        {
            return base.ToString() + $" Company: {Company}" + Soprannome;
            //return $"{FirstName} Company: {Company}";
        }

        public override void Saluta()
        {
            Console.WriteLine("Ciao sono un impiegato.");
        }

        public override void ChiamaTizio()
        {
            Console.WriteLine("Sono un impiegato e sto sto chimando Tizio");
        }
    }
}
