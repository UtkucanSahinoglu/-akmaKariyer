public class Position
{
    public int Id { get; set; }
    //public int DepartmentId { get; set; }
    public string Name { get; set; }
    //public virtual IEnumerable <Department>? Departments { get; set; }
    public virtual IEnumerable <JobAdvertisement>? JobAdvertisements { get; set; }
    public virtual IEnumerable <Position_Department>? Position_Departments { get; set; }

}