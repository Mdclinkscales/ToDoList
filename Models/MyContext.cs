using Microsoft.EntityFrameworkCore;
namespace Office.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<Todo> Todos {get;set;}
        public DbSet<Participation> Participations {get;set;}
    }
}