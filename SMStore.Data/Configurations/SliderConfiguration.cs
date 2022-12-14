using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMStore.Entities;

namespace SMStore.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.Property(x => x.Image).HasMaxLength(100);
            builder.Property(x => x.Link).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(300);
        }
    }
}
