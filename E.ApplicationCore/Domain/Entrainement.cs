using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Entrainement
    {
        [Key]
        public int NumEntrainement { get; set; }
        public DateTime DateEntrainement { get; set; }
        public int DiastanceAParcourir { get; set; }
        public int NombreSeance { get; set; }
        public Piscine Piscine { get; set; }
        public IList<PlanEntrainement> PlanEntrainements { get; set; }
    }
}
