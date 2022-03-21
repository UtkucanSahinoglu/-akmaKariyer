public static class JobPostingCategoryDatebaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sector>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
        });
        
        modelBuilder.Entity<Department>(entity=>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
            //entity.HasMany(e =>e.Sectors).WithMany(e =>e.Department).UsingEntity(e =>e.ToTable("Department_Sector"));
            
        });
        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
            //entity.HasMany(e =>e.Departments).WithMany(e =>e.Positions).UsingEntity(e =>e.ToTable("Position_Department"));

        });
        modelBuilder.Entity<Department_Sector>(entity =>
        {
            entity.HasKey(t =>new{t.SectorId,t.DepartmentId});
            entity.HasOne(e =>e.department).WithMany(e =>e.Department_Sectors).HasForeignKey(e =>e.DepartmentId);
            entity.HasOne(e =>e.sector).WithMany(e =>e.Department_Sectors).HasForeignKey(e =>e.SectorId);

        });
        modelBuilder.Entity<Position_Department>(entity =>
        {
            entity.HasKey(t =>new{t.PositionId,t.DepartmentId});
            entity.HasOne(e =>e.department).WithMany(e =>e.Position_Departments).HasForeignKey(e =>e.DepartmentId);
            entity.HasOne(e =>e.position).WithMany(e =>e.Position_Departments).HasForeignKey(e =>e.PositionId);

        });
    }
}