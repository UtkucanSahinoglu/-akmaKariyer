public class Department
{
    public int Id { get; set; }
    //public int SectorId { get; set; }
    //public int PositionId { get; set; }
    public string Name { get; set; }
    //public virtual IEnumerable <Sector>? Sectors { get; set; }
    //public virtual IEnumerable <Position>? Positions { get; set; }
    public virtual IEnumerable <JobAdvertisement>? JobAdvertisements { get; set; }
    public virtual IEnumerable <Department_Sector>? Department_Sectors { get; set; }
    public virtual IEnumerable <Position_Department>? Position_Departments { get; set; }
}