using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRendezVous.Core.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceNom { get; set; }
        public string Description { get; set; }
        public int Horaire { get; set; }
        public int NbMaxPersonnes { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public string TypeAtelier { get; set; }
        public string TypeDeRdv { get; set; }

      

    }
}