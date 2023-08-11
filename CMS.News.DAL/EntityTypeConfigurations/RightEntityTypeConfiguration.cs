namespace CMS.BillMaker.DAL.EntityTypeConfigurations
{
    internal class RightEntityTypeConfiguration : IEntityTypeConfiguration<Right>
    {
        public void Configure(EntityTypeBuilder<Right> builder)
        {
            builder.ToTable("Right").HasKey(x => x.Id);
        }
    }
}