using Microsoft.EntityFrameworkCore;
using PlannerAPI.Models;

namespace PlannerAPI.Data
{
    public class plannerAPIDbContext : DbContext

    {
        public plannerAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Plan> Planner { get; set; }
    }
}
