using cSharpAcademy_Phone_Book.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace cSharpAcademy_Phone_Book
{
    public class MyDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                string connectionString = ConfigurationManager.AppSettings.Get("dbConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
