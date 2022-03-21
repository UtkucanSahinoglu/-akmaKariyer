public class JobAdvertisementDetail
{
    public int Id { get; set; }
    public string GeneralProperties { get; set; }
    public string JobDefinition { get; set; }
    public string JobRequirements { get; set;}
    public string WorkExperince { get; set; }
    public string EducationStatus { get; set; }
    public string ForeignLanguage { get; set; }
    public string WorkplaceInfo { get; set; }
    public string OpenAddress { get; set; }
    public virtual IEnumerable <JobAdvertisement>? JobAdvertisements { get; set; }
    public int AddressId { get; set; }
    public Address? Addresses { get; set; }
    
}