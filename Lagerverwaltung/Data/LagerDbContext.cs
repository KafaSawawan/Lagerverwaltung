using Lagerverwaltung.Models;
using Microsoft.EntityFrameworkCore;

namespace Lagerverwaltung.Data;

public class LagerDbContext : DbContext
{
    public DbSet<Artikel> Artikel { get; set; }
    public DbSet<Benutzer> Benutzer { get; set; }
    public DbSet<Lagerplatz> Lagerplatz { get; set; }
    public LagerDbContext(DbContextOptions<LagerDbContext> options) : base(options) { }
}
