using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public enum CathegoryAthlete
    {
        Benjamin,
        Cadet,
        Junior,
        Senior,
        Veteran
    }
    public class Athlete
    {
        [Key]
        public int NumeroLicence { get; set; }
        [Required]
        public CathegoryAthlete Cathegory { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string NomAthlete { get; set; }
        public string PrenomAthlete { get; set; }
        public IList<PlanEntrainement> planEntrainements { get; set; }
    }
}
