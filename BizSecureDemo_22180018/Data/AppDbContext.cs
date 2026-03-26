using BizSecureDemo_22180018.Models;
using Microsoft.EntityFrameworkCore;

namespace BizSecureDemo_22180018.Data;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users => Set<AppUser>();
    public DbSet<Order> Orders => Set<Order>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}