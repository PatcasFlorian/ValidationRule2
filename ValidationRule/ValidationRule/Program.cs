using System;

namespace ValidationRule
{
    class Program
    {

        static void Main(string[] args)
        {
            string nume = "Ivan";
            string prenume = "Alex";
            string cnp = "122345";
            int varsta = 32;
            string nume1 = "Popescu";
            string prenume1 = "Darius";
            string cnp1 = "122345233";
            int varsta1 = 15;

            bool isName = true;
            PersonListProcesor personList = new PersonListProcesor(nume, prenume, cnp, varsta);
            PersonListProcesor person2 = new PersonListProcesor(nume1, prenume1, cnp1, varsta1);
            isName = personList.PersonName(nume, prenume, cnp, varsta);
            if (isName == true)
            {
                Console.WriteLine($"Person :{personList.Nume} |Prenume  {personList.Prenume} |CNP :  {personList.Cnp} |Varsta {personList.Varsta}");

            }
            else { Console.WriteLine("is not a valid person"); }
            isName = person2.PersonName(nume1, prenume1, cnp1, varsta1);
            if (isName == true)
            {

                Console.WriteLine($"Person :{person2.Nume} |Prenume : {person2.Prenume} |CNP : {person2.Cnp} |Varsta: {person2.Varsta}");
            }
            else { Console.WriteLine("is not a valid person"); }
        }
    }
}