using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationRule
{
    public abstract class ValidationRule
    {

        public abstract bool PersonName(string nume, string prenume, string cnp, int varsta);


    }
}

