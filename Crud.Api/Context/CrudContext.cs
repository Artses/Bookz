using Crud.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Api.Context
{
    public class CrudContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public static string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Bookz;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
