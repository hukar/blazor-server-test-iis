using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerTestIis.Infrastructure;

public class RobotSeeding : IEntityTypeConfiguration<Robot>
{
    public void Configure(EntityTypeBuilder<Robot> builder)
    {
        builder.HasData(
            new Robot() { Id = 1, Code = "TOTO-88", Power = 3000, CyberBrainId = 11 },
            new Robot() { Id = 2, Code = "MITO-PO", Power = 88, CyberBrainId = 12 }
        );
    }
}
