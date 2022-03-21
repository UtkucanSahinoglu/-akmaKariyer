public static class AddressDatabaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.Property(e =>e.OpenAddress);
            entity.HasOne(e =>e.City).WithMany(e =>e.Addresses).HasForeignKey(e =>e.CityId);
            entity.HasOne(e =>e.District).WithMany(e =>e.Addresses).HasForeignKey(e =>e.DistrictId);
            entity.HasOne(e =>e.AccountEmployerDetails).WithMany(e =>e.Addresses).HasForeignKey(e =>e.AccountEmployerDetailId);


        });
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);

        });
        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.HasOne(e =>e.City).WithMany(e =>e.District).HasForeignKey(e =>e.CityId);
        });
    }
}