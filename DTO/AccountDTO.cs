public class AccountDTO
{
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsBlocked { get; set; }
    public bool Visibility { get; set; }

    public AccountDTO(Account account) 
    {   
        this.Email = account.Email;
       // this.IsBlocked = account.IsBlocked;
       // this.Visibility=account.Visibility;
        this.Password = account.Password;
    }
}