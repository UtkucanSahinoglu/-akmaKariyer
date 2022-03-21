public class Account_Role
{
    public int AccountId { get; set; }
    public int RoleId { get; set; }
    public Account? Account { get; set; }
    public Role? Role { get; set; }
}