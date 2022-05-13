namespace BlazorServerTestIis.Infrastructure;

public class RobotContext : DbContext
{
    public RobotContext(DbContextOptions<RobotContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CyberBrainSeeding());
        modelBuilder.ApplyConfiguration(new RobotSeeding());
    }

    public DbSet<Robot> Robots => Set<Robot>();
    public DbSet<CyberBrain> CyberBrains => Set<CyberBrain>();
}
