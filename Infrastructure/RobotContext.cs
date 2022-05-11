namespace BlazorServerTestIis.Infrastructure;

public class RobotContext : DbContext
{
    public RobotContext(DbContextOptions<RobotContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CyberBrain>().HasData(
            new CyberBrain() { Id = 11, Label = "SpeedResponseAlgebra-6700", CyberQi = 120, Cost = 567 },
            new CyberBrain() { Id = 12, Label = "Alpha-One-77TT", CyberQi = 132, Cost = 845 },
            new CyberBrain() { Id = 13, Label = "Razor-flight-500", CyberQi = 160, Cost = 1234 },
            new CyberBrain() { Id = 14, Label = "SRAlgebra2-9900", CyberQi = 205, Cost = 1409 },
            new CyberBrain() { Id = 15, Label = "Futuratron-tronic-ct56", CyberQi = 320, Cost = 7172 }
        );
    }

    public DbSet<Robot> Robots => Set<Robot>();
    public DbSet<CyberBrain> CyberBrains => Set<CyberBrain>();
}
