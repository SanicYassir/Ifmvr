using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRendezVous.Core.Models
{
    public class ServiceProlongement
    {
        public int ServiceProlongementID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public int MaxDePersonnes { get; set; }
        public int horaires { get; set; }
        
        public ICollection<Service> Services { get; set; }
    }
}