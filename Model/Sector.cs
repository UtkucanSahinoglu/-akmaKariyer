public class Sector
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public virtual IEnumerable <Department>? Department { get; set; }
    public virtual IEnumerable <AccountEmployerDetail>? AccountEmployerDetails { get; set; }
    public virtual IEnumerable <JobAdvertisement>? JobAdvertisements { get; set; }
    public virtual IEnumerable <Department_Sector>? Department_Sectors { get; set; }
}