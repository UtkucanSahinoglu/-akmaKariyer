public static class JobAdvertisementDatabaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobAdvertisement>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
            entity.Property(e =>e.PositionName);
            entity.Property(e =>e.DepartmentName);
            entity.Property(e =>e.SectorName);
            entity.Property(e =>e.CompanyName);
            entity.Property(e =>e.NumberOfApplications);
            entity.Property(e =>e.CityName);
            entity.Property(e =>e.DistrictName);
            entity.HasOne(e =>e.workType).WithMany(e =>e.JobAdvertisements).HasForeignKey(e =>e.WorkTypeId);
            entity.HasOne(e =>e.Positions).WithMany(e =>e.JobAdvertisements).HasForeignKey(e =>e.PositionId);
            entity.HasOne(e =>e.Departments).WithMany(e =>e.JobAdvertisements).HasForeignKey(e =>e.DepartmentId);
            entity.HasOne(e =>e.Sectors).WithMany(e =>e.JobAdvertisements).HasForeignKey(e =>e.SectorId);
            //entity.HasMany(e =>e.AccountEmployerDetails).WithMany(e =>e.JobAdvertisement).UsingEntity(e =>e.ToTable("AccountEmployerDetail_JobAdvertisement"));
        });
        modelBuilder.Entity <JobAdvertisementDetail>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.GeneralProperties);
            entity.Property(e =>e.JobDefinition);
            entity.Property(e =>e.JobRequirements);
            entity.Property(e =>e.WorkExperince);
            entity.Property(e =>e.EducationStatus);
            entity.Property(e =>e.ForeignLanguage);
            entity.Property(e =>e.WorkplaceInfo);
            entity.Property(e =>e.OpenAddress);
            entity.HasMany(e =>e.JobAdvertisements).WithOne(e =>e.JobAdvertisementDetails).HasForeignKey(e =>e.JobAdvertisementDetailId);
            entity.HasOne(e =>e.Addresses).WithMany(e =>e.JobAdvertisementDetails).HasForeignKey(e =>e.AddressId);
        });
        modelBuilder.Entity <AccountEmployerDetail_JobAdvertisement>(entity =>
        {
            entity.HasKey(t =>new{t.AccountEmployerDetailId,t.JobAdvertisementId});
            entity.HasOne(e =>e.AccountEmployerDetail).WithMany(e =>e.AccountEmployerDetail_JobAdvertisements).HasForeignKey(e =>e.AccountEmployerDetailId);
            entity.HasOne(e =>e.jobAdvertisement).WithMany(e =>e.AccountEmployerDetail_JobAdvertisements).HasForeignKey(e =>e.JobAdvertisementId);

        });
    }
}