using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Piscine
    {
        [Key]
        public int NumPiscine { get; set; }
        [DisplayName("L'adresse de la piscine est")]
        public string NomPiscine { get; set; }
        public string AdressePiscine { get; set; }
        public IList<Entrainement> Entrainements { get; set; }
    }
}
