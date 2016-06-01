using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car
{
    class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string Br_vozacke { get; set; }
        MainPage mainpage;

        public string DajIme()
        {
            ime = mainpage.ime;
            return ime;
        }

        public string DajPrezime()
        {
            prezime = mainpage.prezime;
            return prezime;
        }
        public string DajBrojVozacke()
        {
            Br_vozacke = mainpage.br_vozacke;
            return Br_vozacke;
        }
    }
}
