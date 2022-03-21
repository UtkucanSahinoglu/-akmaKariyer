public class Account
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsBlocked { get; set; }
    public bool Visibility { get; set; }
    //public virtual IEnumerable <AccountStudentDetail> AccountStudents { get; set; }
    //public virtual IEnumerable <AccountEmployerDetail> AccountEmployers { get; set; }

    //public AccountEmployerDetail? AccountEmployerDetail { get; set; }
    //public AccountStudentDetail? AccountStudentDetail { get; set; }
    
    //public int RoleId { get; set; }
    //public Role Roles { get; set; }
    public virtual IEnumerable <Account_Role>? Account_Roles { get; set; }
    public Account()
    {

    }

    public Account(AccountDTO incomingAccount) 
    {
        this.Email = incomingAccount.Email;
        this.Password = incomingAccount.Password;
    }

}