using DMS_EmployeeRegistration_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS_EmployeeRegistration_API.Data
{
    public class EmployeeRegistrationDbContext : DbContext
    {
        public EmployeeRegistrationDbContext (DbContextOptions<EmployeeRegistrationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = default!;
    }
}
