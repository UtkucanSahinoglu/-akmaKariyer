public class AccountEmployerDetail
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string WorkplaceInfo { get; set; }
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public int SectorId { get; set; }
    public virtual Sector? Sectors { get; set; }
    public virtual Account? Accounts { get; set; }
    //public virtual IEnumerable <JobAdvertisement>? JobAdvertisement { get; set; }
    public string OpenAddress { get; set; }
    public virtual IEnumerable <Address>? Addresses { get; set; }
    public virtual IEnumerable <AccountEmployerDetail_JobAdvertisement>? AccountEmployerDetail_JobAdvertisements { get; set; }
    //public int RoleId { get; set; }
    //public virtual Role? Role { get; set; }
    //public IEnumerable <AccountEmployerDetail>? AccountEmployerDetails { get; set; }

}