public class Role
{
    public int Id { get; set; }
    public string RoleType { get; set; }
    public bool Visibility { get; set; }
    public virtual IEnumerable <Account_Role>? Account_Roles { get; set; }
    
    //public virtual IEnumerable <Account>? Accounts { get; set; }
    //public virtual IEnumerable <AccountStudentDetail>? AccountStudents { get; set; }
    //public virtual IEnumerable <AccountEmployerDetail>? AccountEmployers { get; set; }

}