using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRendezVous.Core.Models
{
    public class HorairesIndisponible
    {
        public int HorairesIndisponibleID { get; set; }
        public string JourNom { get; set; }

        public string HeureDebutMatin { get; set; }
        public string HeureFinMatin { get; set; }

        public string HeureDebutApresMidi { get; set; }
        public string HeureFinApresMidi { get; set; }

        public string TypeAnnulation { get; set; }
        public ICollection<Emplois> Emplois{ get; set; }
    }
}