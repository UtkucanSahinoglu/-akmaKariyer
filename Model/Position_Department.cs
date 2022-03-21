public class Position_Department
{
    public int PositionId { get; set; }
    public int DepartmentId { get; set; }
    public Position? position { get; set; }
    public Department? department { get; set; }
}