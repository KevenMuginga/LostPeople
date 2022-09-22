using LostPeople.Models;
using System.Data.Entity;

namespace LostPeople.App_Data
{
    public class LostDbContext : DbContext
    {
        public LostDbContext() : base(@"Data Source=DESKTOP-EFTV18J\SQLSERVE;Initial Catalog=Pessoas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Losted> Losts { get; set; }
        public DbSet<Finded> Finds { get; set; }
        public DbSet<Usuario> Users { get; set; }

    }
}
