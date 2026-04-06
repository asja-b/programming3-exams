using DLWMS.Data;
using DLWMS.Data.ispitIB230030;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<UniverzitetiIB230030> UniverzitetiIB230030 { get; set; }
        public DbSet<RazmjeneIB230030> RazmjeneIB230030 { get; set; }

    }
}
