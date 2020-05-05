using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationRule
{
    public class PersonListProcesor : ValidationEngine
    {
        public PersonListProcesor(string nume, string prenume, string cnp, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Cnp = cnp;
            Varsta = varsta;

        }

        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public string Cnp { get; private set; }
        public int Varsta { get; private set; }

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
                Console.WriteLine("CNP Gresit");
                isPerson = false;
                return isPerson;
            }
            if (varsta < 18)
            {
                Console.WriteLine("Este minor");
                isPerson = false;
                return isPerson;
            }
            return isPerson;
        }
    }
}