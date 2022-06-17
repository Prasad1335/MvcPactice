using Microsoft.EntityFrameworkCore;
using MvcPactice.Models;

namespace MvcPactice.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Department> department { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=UserManagment;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
