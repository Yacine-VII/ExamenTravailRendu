using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class PlanEntrainement
    {
        public int IdPlanEntrainement { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int DistanceParcourue { get; set; }
        public int NumEntrainementFk { get; set; }
        public int NumLicenceFk { get; set; }
        public Entrainement Entrainement { get; set; }
        public Athlete Athele { get; set; }
    }
}
