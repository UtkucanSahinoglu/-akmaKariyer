public static class AccountDatabaseBuilder
{
    
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
         {
             entity.HasKey(e =>e.Id);
             entity.Property(e =>e.Email).IsRequired();
             entity.Property(e =>e.Password).IsRequired();
             entity.Property(e =>e.IsBlocked);
             entity.Property(e =>e.Visibility);
             //entity.HasMany(e =>e.AccountEmployers).WithOne(e =>e.Accounts).HasForeignKey(e =>e.AccountId);
            // entity.HasMany(e =>e.AccountStudents).WithOne(e =>e.Accounts).HasForeignKey(e =>e.AccountId);

         });
         //role id ve account idlerin tutulduğu ekstra bir tablo eklenecek
         //eklendi

        modelBuilder.Entity<Role>(entity =>
       {
           entity.HasKey(e =>e.Id);
           entity.Property(e =>e.RoleType).IsRequired();
           entity.Property(e =>e.Visibility);
           //entity.HasMany(e =>e.Accounts).WithOne(e =>e.Roles).HasForeignKey(e =>e.RoleId);

       });
        modelBuilder.Entity<AccountEmployerDetail>(entity =>
       {
           entity.HasKey(e =>e.Id);
           entity.Property(e =>e.Name).IsRequired();
           entity.Property(e =>e.LastName).IsRequired();
           entity.Property(e =>e.WorkplaceInfo);
           entity.Property(e =>e.CompanyName);
           entity.Property(e =>e.PhoneNumber);
           entity.Property(e =>e.OpenAddress);
           //entity.HasOne(e =>e.Role).WithMany(e =>e.AccountEmployers).HasForeignKey(e =>e.RoleId);
           entity.HasOne(e =>e.Sectors).WithMany(e =>e.AccountEmployerDetails).HasForeignKey(e =>e.SectorId);

       });
        modelBuilder.Entity<AccountStudentDetail>(entity =>
       {
           entity.HasKey(e =>e.Id);
           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.LastName).IsRequired();
           entity.Property(e =>e.EducationStatus).IsRequired();
           entity.Property(e =>e.Abilities).IsRequired();
           entity.Property(e =>e.PhoneNumber).IsRequired();
           entity.Property(e =>e.ImageUrl);
           entity.Property(e =>e.WorkExperince);
           //entity.HasOne(e =>e.Role).WithMany(e =>e.AccountStudents).HasForeignKey(e =>e.RoleId);

       });
       modelBuilder.Entity<Account_Role>(entity =>
       {
           entity.HasKey(t =>new{t.AccountId,t.RoleId});
           entity.HasOne(e =>e.Account).WithMany(e =>e.Account_Roles).HasForeignKey(e =>e.AccountId);
           entity.HasOne(e =>e.Role).WithMany(e =>e.Account_Roles).HasForeignKey(e =>e.RoleId);

       });
    }

}