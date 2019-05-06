using Microsoft.EntityFrameworkCore;
using Star.Data.Models;

namespace Star.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
