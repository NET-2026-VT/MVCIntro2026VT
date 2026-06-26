using Microsoft.EntityFrameworkCore;

public class MVCIntro2026VTContext(DbContextOptions<MVCIntro2026VTContext> options) : DbContext(options)
{
    public DbSet<MVCIntro2026VT.Models.Employee> Employee { get; set; } = default!;
}
