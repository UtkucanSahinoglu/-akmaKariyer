public class AccountEmployerDetail_JobAdvertisement
{
    public int AccountEmployerDetailId { get; set; }
    public int JobAdvertisementId { get; set; }
    public JobAdvertisement? jobAdvertisement { get; set; }
    public AccountEmployerDetail? AccountEmployerDetail { get; set; }
}