using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRendezVous.Core.Models
{
    public class Emplois
    {
        public int JourID { get; set; }
        public string JourNom { get; set; }

        public string HeureDebutMatin { get; set; }
        public string HeureFinMatin { get; set; }

        public string HeureDebutApresMidi { get; set; }
        public string HeureFinApresMidi { get; set; }
        public bool IsDisponible { get; set; }
        public bool JourAnnuler { get; set; }
        ICollection<Service> Services { get; set; }
    }
}