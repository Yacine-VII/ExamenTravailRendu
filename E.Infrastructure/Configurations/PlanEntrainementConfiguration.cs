using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configurations
{
    public class PlanEntrainementConfiguration : IEntityTypeConfiguration<PlanEntrainement>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PlanEntrainement> builder)
        {
            //3 a
            builder.HasOne(p => p.Entrainement)
                .WithMany(e => e.PlanEntrainements)
                .HasForeignKey(p => p.NumEntrainementFk);

            builder.HasOne(p => p.Athele)
                .WithMany(a => a.planEntrainements)
                .HasForeignKey(p => p.NumLicenceFk);
            //3 b
            builder.HasKey(p => new
            {
                p.IdPlanEntrainement,
                p.NumEntrainementFk,
                p.NumLicenceFk
            });

        }
    }
}
