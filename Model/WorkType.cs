public class WorkType
{
    public int Id { get; set; }
    public int JobAdvertisementId { get; set; }
    public string WorkTime { get; set; }
    public virtual IEnumerable <JobAdvertisement>? JobAdvertisements { get; set; }
}