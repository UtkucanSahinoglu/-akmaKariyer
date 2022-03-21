public class Department_Sector
{
    public int DepartmentId { get; set; }
    public int SectorId { get; set; }
    public Department? department { get; set; }
    public Sector? sector { get; set; }

}