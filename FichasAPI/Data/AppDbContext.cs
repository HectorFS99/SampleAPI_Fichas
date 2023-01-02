using FichasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FichasAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Ficha> Fichas { get; set; }
}