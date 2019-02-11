using GigHub.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace GigHub.Persistence.EntityConfigurations
{
    public class GigConfiguration : EntityTypeConfiguration<Gig>
    {
        public GigConfiguration()
        {
            
               Property(g => g.ArtistId)
                .IsRequired();
 
               Property(g => g.Venue)
                .IsRequired()
                .HasMaxLength(255);
     
               Property(g => g.Venue)
                .IsRequired();

               HasMany(g => g.Attendances)
                   .WithRequired( g => g.Gig)
                   .WillCascadeOnDelete(false);
 
        }
    }
}