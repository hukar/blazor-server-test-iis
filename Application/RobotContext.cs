namespace BlazorServerTestIis.Application;

public class RobotContext : DbContext
{
    public RobotContext(DbContextOptions<RobotContext> options) : base(options)
    {
        
    }

    public DbSet<Robot> Robots => Set<Robot>();
    public DbSet<CyberBrain> CyberBrains => Set<CyberBrain>();
}
