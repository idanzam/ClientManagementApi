using Microsoft.EntityFrameworkCore;
using ClientManagementApi.Models;

namespace ClientManagementApi.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>().ToTable("clients");


            // Seed data
            modelBuilder.Entity<Client>().HasData(
                new Client { id = 1, firstname = "John", lastname = "Doe", phone = "1234567890", address = "123 Main St", gender = "Male", email = "john.doe@example.com" },
                new Client { id = 2, firstname = "Jane", lastname = "Doe", phone = "0987654321", address = "456 Elm St", gender = "Female", email = "jane.doe@example.com" }
            );
        }
    }
}
