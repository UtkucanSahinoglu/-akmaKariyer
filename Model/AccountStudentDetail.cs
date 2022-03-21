public class AccountStudentDetail
{
    public int AccountId{ get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string EducationStatus { get; set; }
    public string Abilities { get; set; }
    public string ImageUrl { get; set; }
    public string PhoneNumber { get; set; }
    public string WorkExperince { get; set; }
    public virtual Account? Accounts { get; set; }
    //public int RoleId { get; set; }
    //public virtual Role? Role { get; set; }
    //public IEnumerable <AccountStudentDetail>? AccountStudentDetails { get; set; }

}