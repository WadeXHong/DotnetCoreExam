using Microsoft.EntityFrameworkCore;
using Course.WebApi.Models;

namespace Course.WebApi.Repositories
{
    
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        // DbSet 用來指定要使用的 table類別
        public DbSet<Employee> WeatherForecasts { get; set; }
    }
}