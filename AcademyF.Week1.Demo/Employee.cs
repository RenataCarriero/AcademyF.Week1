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
            return base.ToString() + $" Company: {Company}";
            //return $"{FirstName} Company: {Company}";
        }
    }
}
