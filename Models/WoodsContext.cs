using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LostintheWoods.Models
{
    public class WoodsContext : DbContext
    {
        public WoodsContext(DbContextOptions options) : base(options) {}

        public DbSet<Woods> Wood {get;set;}
    }
}