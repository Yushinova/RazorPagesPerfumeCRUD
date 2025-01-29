using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesPerfumeCRUD.Model
{
    public class ApplicationDbContext: DbContext
    {
        public required DbSet<Perfume> Perfumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-H7HCK7B\\SQLEXPRESS;Initial Catalog=CatalogPerfume;Integrated Security=SSPI;Timeout=10;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
