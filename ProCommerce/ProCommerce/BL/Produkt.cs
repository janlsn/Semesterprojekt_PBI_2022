using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommerce.BL
{
    class Produkt
    {
        public string adresse, postnr, bynavn, telefon, varenummer, produktnavn, antal, pris, lokation, reolnr, hyldenr, status;
        public Produkt(string adresse, string postnr, string bynavn, string telefon, string varenummer, string produktnavn, string antal, string pris, string lokation, string reolnr, string hyldenr, string status)
        {
            this.adresse = adresse;
            this.postnr = postnr;
            this.bynavn = bynavn;
            this.telefon = telefon;
            this.varenummer = varenummer;
            this.produktnavn = produktnavn;
            this.antal = antal;
            this.pris = pris;
            this.lokation = lokation;
            this.reolnr = reolnr;
            this.hyldenr = hyldenr;
            this.status = status;

        }
    }
}
