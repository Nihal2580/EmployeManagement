

using EmployeManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeManagement.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees{  get; set; }
    }
}
