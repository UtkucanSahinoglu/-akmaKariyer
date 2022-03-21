public class JobAdvertisement
{
    public int Id { get; set; }
    //public int AccountEmployerDetailId { get; set; }
    public int JobAdvertisementDetailId { get; set; }
    public int PositionId { get; set; }
    public int DepartmentId { get; set; }
    public int SectorId { get; set; }
    public virtual Position? Positions { get; set; }
    public virtual Department? Departments { get; set; }
    public virtual Sector? Sectors { get; set; }
    //public virtual IEnumerable <AccountEmployerDetail>? AccountEmployerDetails { get; set; }
    public JobAdvertisementDetail? JobAdvertisementDetails { get; set; }
    public string Name { get; set; }
    public string PositionName { get; set; }
    public string DepartmentName { get; set; }
    public string SectorName { get; set; }
    public string CompanyName { get; set; }
    public int NumberOfApplications { get; set; }
    public int WorkTypeId { get; set; }
    public virtual WorkType? workType { get; set; }
    public string CityName { get; set; }
    public string DistrictName { get; set; }
    public virtual IEnumerable <AccountEmployerDetail_JobAdvertisement>? AccountEmployerDetail_JobAdvertisements { get; set; }


}