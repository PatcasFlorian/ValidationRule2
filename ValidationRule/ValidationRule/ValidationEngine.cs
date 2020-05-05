using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationRule
{
    public class ValidationEngine : ValidationRule
    {
        public ValidationEngine()
        {
        }

        public ValidationEngine(string nume, string prenume, string cnp, int varsta)
        {
            Varsta = varsta;
            Nume = nume;
            Prenume = prenume;
            Cnp = cnp;
        }

        public int Varsta { get; }
        public string Nume { get; }
        public string Prenume { get; }
        public string Cnp { get; }
        public override bool PersonName(string nume, string prenume, string cnp, int varsta)
        {
            int newCnp;
            bool isPerson = true;
            if ((string.IsNullOrEmpty(nume)) && (string.IsNullOrEmpty(prenume)))
            {
                isPerson = false;
                return isPerson;
            }
            if (!Int32.TryParse(cnp, out newCnp))
            {
                isPerson = false;
                return isPerson;
            }
            return isPerson;
        }


    }
}
